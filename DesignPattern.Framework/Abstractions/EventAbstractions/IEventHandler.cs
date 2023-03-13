namespace DesignPattern.Framework.Abstractions.EventAbstractions
{
    public interface IEventHandler<IEvent>
    {
        void Handle(IEvent @event);
    }
}
