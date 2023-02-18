namespace DesignPattern.Observer;

public class Parent : IObserver
{
    public int Score { get; set; } = 15;

    public override string ToString()
    {
        return "Parent Score: " + Score;
    }
}
