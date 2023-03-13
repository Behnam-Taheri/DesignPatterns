namespace DesignPattern.Builder.Models
{
    public class Maze
    {
        public Maze()
        {
            Doors = new List<int>();
            Rooms = new List<string>();
        }

        public List<int> Doors { get; set; }
        public List<string> Rooms { get; set; }
    }
}
