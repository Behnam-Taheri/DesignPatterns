namespace DesignPattern.Observer;

public class Support : IObserver
{
    public int Score { get; set; } = 8;

    public override string ToString()
    {
        return "Support Score: " + Score;
    }
}