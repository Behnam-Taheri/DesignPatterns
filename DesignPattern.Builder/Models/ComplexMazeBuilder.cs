namespace DesignPattern.Builder.Models
{
    public class ComplexMazeBuilder : IBuilder
    {
        private Maze maze;
        public ComplexMazeBuilder()
        {
            maze = new Maze();
        }
        public IBuilder AddDoor(int doorNumber)
        {

            maze.Doors.Add(doorNumber);
            return this;
        }

        public IBuilder AddRoom(string roomName)
        {
            roomName += "----------------";
            maze.Rooms.Add(roomName);
            return this;
        }

        public Maze Build()
        {
            return maze;
        }
    }
}
