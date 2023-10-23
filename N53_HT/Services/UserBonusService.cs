using N53_HT.Events;
using N53_HT.Models;
using N53_HT.Services.Interfaces;

namespace N53_HT.Services;

public class UserBonusService : IUserBonusService
{
    private readonly OrderEventStore _orderEventStore;
    private readonly BonusEventStore _bonusEventStore;
    private readonly IEnumerable<INotificationService> _notificationServices;
    private readonly IBonusService _bonusService;
    private readonly IUserService _userService;

    public UserBonusService(
        OrderEventStore orderEventStore,
        BonusEventStore bonusEventStore,
        IEnumerable<INotificationService> notificationServices,
        IBonusService bonusService,
        IUserService userService)
    {
        _orderEventStore = orderEventStore;
        _bonusEventStore = bonusEventStore;
        _notificationServices = notificationServices;
        _bonusService = bonusService;
        _userService = userService;

        _orderEventStore.OrderCreatedEvent += CreateOrderAsync;
    }

    public async ValueTask CreateOrderAsync(Order order)
    {
        Console.WriteLine("Notifying user");

        var bonus = _bonusService.Get(b => b.UserId == order.UserId).FirstOrDefault();
        if (bonus is null)
        {
            await _bonusService.CreateAsync(new Bonus { Id = Guid.NewGuid(), UserId = order.UserId, Amount = order.Price });
            return;
        }

        var oldAmount = bonus.Amount;
        var updatedBonus = new Bonus { Id = bonus.Id, UserId = bonus.UserId, Amount = bonus.Amount + order.Price };

        var achievment = ToAchieveBonus(oldAmount, updatedBonus.Amount);
        if (achievment <= 0)
            await _bonusService.UpdateAsync(updatedBonus);
        else
        {
            var message = $"The need amount to achieve next bonus {achievment}";
            Task.WhenAll(_notificationServices
                .Select(notificationService => notificationService
                .SendAsync(new User(), message).AsTask()));
        }
    }

    private decimal ToAchieveBonus(decimal oldBonus, decimal newBonus)
    {
        var number = oldBonus;
        var lengthOfNumber = 0;
        while (number >= 1)
        {
            number /= 10;
            lengthOfNumber += 1;
        }

        var nextNumber = Math.Pow(10, lengthOfNumber);
        return (decimal)nextNumber - newBonus;
    }
}