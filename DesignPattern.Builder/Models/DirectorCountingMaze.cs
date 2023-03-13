using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Builder.Models
{
    public class DirectorCountingMaze
    {
        private readonly IBuilder builder;
        public DirectorCountingMaze(IBuilder builder)
        {
            this.builder = builder;
        }

        public Maze BuildCountingMaze()
        {
            var maze = builder.AddRoom("Room Enter").AddDoor(2).AddDoor(3).AddRoom("Room External").AddDoor(1)
                .Build();

            return maze;
        }
    }
}
