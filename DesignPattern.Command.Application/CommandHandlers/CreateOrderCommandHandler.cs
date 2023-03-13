using DesignPattern.Command.Application.Commands;
using DesignPattern.Command.Application.Events;
using DesignPattern.Framework.Abstractions;
using DesignPattern.Framework.Abstractions.EventAbstractions;

namespace DesignPattern.Command.Application.CommandHandlers
{
    public class CreateOrderCommandHandler : ICommandHandler<CreateOrderCommand>
    {
        private readonly IEventBus eventBus;

        public CreateOrderCommandHandler(IEventBus eventBus)
        {
            this.eventBus = eventBus;
        }

        public void Handle(CreateOrderCommand command)
        {
            //Actions


            eventBus.Publish(new OrderCreatedEvent
            {
                Id = 11
            });
        }
    }
}
