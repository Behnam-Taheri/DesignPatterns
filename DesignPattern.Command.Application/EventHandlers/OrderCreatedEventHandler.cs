using DesignPattern.Command.Application.Events;
using DesignPattern.Framework.Abstractions.EventAbstractions;

namespace DesignPattern.Command.Application.EventHandlers
{
    public class OrderCreatedEventHandler : IEventHandler<OrderCreatedEvent>
    {
        public void Handle(OrderCreatedEvent @event)
        {
           
        }
    }
}
