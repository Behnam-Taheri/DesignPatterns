namespace DesignPattern.Observer;

public class Student : IObserver
{
    public int Score { get; set; } = 0;

    public override string ToString()
    {
        return "Student Score: " + Score;
    }
}
