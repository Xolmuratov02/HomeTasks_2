using N53_HT.Events;
using N53_HT.Models;
using N53_HT.Services.Interfaces;

namespace N53_HT.Services;

public class UserPromotionService : IUserPromotionService
{
    private readonly IEnumerable<INotificationService> _notificationServices;
    private readonly BonusEventStore _bonusEventStore;
    public UserPromotionService(IEnumerable<INotificationService> notificationServices, BonusEventStore bonusEventStore)
    {
        _notificationServices = notificationServices;
        _bonusEventStore = bonusEventStore;

        _bonusEventStore.BonusAchievedEvent += UpdateBonusAsync;
    }
    public async ValueTask UpdateBonusAsync(Bonus bonus)
    {
        Console.WriteLine("Notifying user");
        var content = "You achieved next bonus";
        Task.WhenAll(_notificationServices
                        .Select(notificationService => notificationService
                        .SendAsync(new User(), content).AsTask()));
    }
}