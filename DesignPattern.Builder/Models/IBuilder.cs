namespace DesignPattern.Builder.Models
{
    public interface IBuilder
    {
        IBuilder AddRoom(string roomName);
        IBuilder AddDoor(int doorNumber);
        Maze Build();
    }
}
