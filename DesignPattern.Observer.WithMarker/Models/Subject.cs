namespace DesignPattern.Observer.WithMarker.Models;

public class Subject : ISubject
{
    private List<IObserver> observers;
    public int Score
    {
        set
        {
            Notify(value);
        }
    }
    public Subject()
    {
        observers = new List<IObserver>();
    }

    public void Add(IObserver observer)
    {
        observers.Add(observer);
    }

    public void Remove(IObserver observer)
    {
        observers.Remove(observer);
    }

    public void Notify(int score)
    {
        //foreach (var observer in observers)
        //{
        //    observer.Update(20);
        //}

        observers.ForEach(x => x.Update(score));
    }
}
