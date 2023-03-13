using DesignPattern.Framework.Abstractions.EventAbstractions;

namespace DesignPattern.Command.Application.Events
{
    public class OrderCreatedEvent : IEvent
    {
        public int Id { get; set; }
    }
}
