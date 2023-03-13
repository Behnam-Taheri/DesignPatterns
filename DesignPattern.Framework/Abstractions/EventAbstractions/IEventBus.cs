namespace DesignPattern.Framework.Abstractions.EventAbstractions
{
    public interface IEventBus
    {
        void Publish<TEvent>(TEvent @event) where TEvent : IEvent;
        void Subscribe<TEvent>(Action<TEvent> @event) where TEvent : IEvent;
    }
}
