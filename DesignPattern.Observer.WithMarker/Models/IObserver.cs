namespace DesignPattern.Observer.WithMarker.Models;

public interface IObserver
{
    public int Score { get; set; }
    public void Update(int score)
    {
        Score = score;
    }
}
