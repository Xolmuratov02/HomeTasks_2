using N53_HT.Data;
using N53_HT.Events;
using N53_HT.Models;
using N53_HT.Services.Interfaces;
using System.Linq.Expressions;

namespace N53_HT.Services;

public class BonusService : IBonusService
{
    private readonly IDataContext _dataContext;
    private readonly BonusEventStore _eventStore;

    public BonusService(IDataContext dataContext, BonusEventStore eventStore)
    {
        _dataContext = dataContext;
        _eventStore = eventStore;
    }

    public async ValueTask<Bonus> CreateAsync(Bonus bonus, bool saveChanges = true, CancellationToken cancellationToken = default)
    {
        await _dataContext.Bonuses.AddAsync(bonus, cancellationToken);

        if (saveChanges)
            await _dataContext.SaveChangesAsync();

        return bonus;
    }

    public IQueryable<Bonus> Get(Expression<Func<Bonus, bool>> predicate) =>
        _dataContext.Bonuses.Where(predicate.Compile()).AsQueryable();

    public async ValueTask<Bonus?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default) => await _dataContext.Bonuses.FindAsync(id, cancellationToken);

    public async ValueTask<Bonus> UpdateAsync(Bonus bonus, bool saveChanges = true, CancellationToken cancellationToken = default)
    {
        var foundBonus = await GetByIdAsync(bonus.Id, cancellationToken) ?? throw new InvalidOperationException("Bonus not found");

        foundBonus.UserId = bonus.UserId;
        foundBonus.Amount = bonus.Amount;
        await _dataContext.Bonuses.UpdateAsync(foundBonus, cancellationToken);
        await _eventStore.AchievedBonusAsync(bonus);

        if (saveChanges)
            await _dataContext.SaveChangesAsync();

        return foundBonus;
    }
}