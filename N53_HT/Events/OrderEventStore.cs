using N53_HT.Models;

namespace N53_HT.Events;

public class OrderEventStore
{
    public event Func<Order, ValueTask>? OrderCreatedEvent;

    public async ValueTask CreatedOrderEventAsync(Order order)
    {
        if (order != null)
            await OrderCreatedEvent(order);
    }
}