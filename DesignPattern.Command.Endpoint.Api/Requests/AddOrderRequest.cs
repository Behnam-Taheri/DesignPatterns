using DesignPattern.Command.Application.Commands;
using System.ComponentModel.DataAnnotations;

namespace DesignPattern.Command.Endpoint.Api.Requests
{
    public record AddOrderRequest
    {
        public string FoodName { get; set; } = null!;
        public string Price { get; set; } = null!;

        public CreateOrderCommand ToCommand()
        {
            return new()
            {
                FoodName = FoodName,
                Price = Price,
            };
        }
    }
}
