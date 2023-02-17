using static System.Formats.Asn1.AsnWriter;

namespace DesignPattern.Observer;

public class Subject : ISubject
{
    public delegate void Updater(int score);

    private Updater? updaters;

    public int Score
    {
        set
        {
            Notify(value);
        }
    }
    public Subject() { }

    public void Add(IObserver observer)
    {
        updaters += observer.Update;
    }

    public void Remove(IObserver observer)
    {
        updaters -= observer.Update;
    }

   public void Notify(int score)
    {
        //foreach (var observer in observers)
        //{
        //    observer.Update(20);
        //}

        if(updaters is not null)
            updaters(score);
    }
}
