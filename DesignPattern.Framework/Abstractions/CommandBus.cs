using DesignPattern.Framework.Abstractions.EventAbstractions;
using Microsoft.Extensions.DependencyInjection;

namespace DesignPattern.Framework.Abstractions
{
    public class CommandBus : ICommandBus, IFluentCommand
    {
        private readonly IServiceProvider serviceProvider;
        private readonly IEventBus eventBus;
        private dynamic _command;
        public CommandBus(IServiceProvider serviceProvider, IEventBus eventBus)
        {
            this.serviceProvider = serviceProvider;
            this.eventBus = eventBus;
        }

        public void Dispatch<TCommand>(TCommand command) where TCommand : ICommand
        {
            var handlers = serviceProvider.GetRequiredService<IEnumerable<ICommandHandler<TCommand>>>().ToList();

            handlers.ForEach(x => x.Handle(command));
        }

        public void DispatchAsync()
        {
            throw new NotImplementedException();
        }

        public IFluentCommand Execute<TCommand>(TCommand command) where TCommand : ICommand
        {
            _command = command;
            return this;
        }

        public IFluentCommand Subscribe<TEvent>(Action<TEvent> @event) where TEvent : IEvent
        {
            eventBus.Subscribe(@event);
            return this;
        }
    }
}
