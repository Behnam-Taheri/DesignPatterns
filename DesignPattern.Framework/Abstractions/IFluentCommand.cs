using DesignPattern.Framework.Abstractions.EventAbstractions;

namespace DesignPattern.Framework.Abstractions
{
    public interface IFluentCommand
    {
        IFluentCommand Subscribe<TEvent>(Action<TEvent> @event) where TEvent : IEvent;

        void DispatchAsync();
    }
}
