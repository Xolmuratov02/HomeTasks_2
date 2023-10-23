using N53_HT.Models;

namespace N53_HT.Services.Interfaces;

public interface IUserBonusService
{
    ValueTask CreateOrderAsync(Order order);

}