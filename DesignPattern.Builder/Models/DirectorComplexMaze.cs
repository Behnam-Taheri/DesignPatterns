namespace DesignPattern.Builder.Models
{
    public class DirectorComplexMaze
    {
        private readonly IBuilder builder;

        public DirectorComplexMaze(IBuilder builder)
        {
            this.builder = builder;
        }

        public Maze BuildComplexMaze()
        {
            var maze = builder.AddRoom("Room Enter").AddDoor(2).AddDoor(3)
                  .AddRoom("Room External").AddDoor(1)
                  .AddRoom("Room 1").AddDoor(1).AddDoor(6)
                  .AddRoom("Room 2").AddDoor(6)
                  .AddRoom("Room 3")
                  .Build();
            return maze;
        }


        public Maze BuildComplexMaze2()
        {
            var maze = builder.AddRoom("Room Enter").AddDoor(2).AddDoor(3)
                  .AddRoom("Room External").AddDoor(1)
                  .Build();
            return maze;
        }
    }
}
