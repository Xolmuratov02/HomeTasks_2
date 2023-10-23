using N53_HT.Models;

namespace N53_HT.Events;

public class BonusEventStore
{
    public event Func<Bonus, ValueTask>? BonusAchievedEvent;

    public async ValueTask AchievedBonusAsync(Bonus bonus)
    {
        if (bonus != null)
            await BonusAchievedEvent(bonus);
    }
}