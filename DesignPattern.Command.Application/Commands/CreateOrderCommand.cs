using DesignPattern.Framework.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Command.Application.Commands
{
    public class CreateOrderCommand : ICommand
    {
        public string FoodName { get; init; }
        public string Price { get; init; }
    }
}
