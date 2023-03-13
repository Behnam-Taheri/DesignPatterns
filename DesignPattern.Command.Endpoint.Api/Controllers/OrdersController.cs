using DesignPattern.Command.Application.Events;
using DesignPattern.Command.Endpoint.Api.Requests;
using DesignPattern.Framework.Abstractions;
using DesignPattern.Framework.Abstractions.EventAbstractions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DesignPattern.Command.Endpoint.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly ICommandBus commandBus;
        public OrdersController(ICommandBus commandBus)
        {
            this.commandBus = commandBus;
        }

        [HttpPost]
        public IActionResult Create(AddOrderRequest addOrderRequest)
        {
            int id = 0;
            //  eventBus.Subscribe<OrderCreatedEvent>(x => id = x.Id);
            // commandBus.Dispatch(addOrderRequest.ToCommand());

            commandBus.Execute(addOrderRequest.ToCommand())
             .Subscribe<OrderCreatedEvent>(x => id = x.Id)
             .DispatchAsync();

            return Created("", id);
        }
    }
}
