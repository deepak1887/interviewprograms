namespace DesignPatters.Observer;
public class Subject : ISubject, IDisposable
{
    readonly List<IObserver> observers = new ();

    private int flag;
    public int Flag
    {
        get { return flag; }
        set
        {
            flag = value;
            Notify(flag);
        }
    }

    public void Dispose()
    {
        foreach (var observer in observers)
        {
            Console.WriteLine(observer.ToString());
            UnSubscribe(observer);
        }
    }

    public void Notify(int i)
    {
        foreach (var observer in observers)
        {
            observer.Update(i);
        }
    }

    public void Subscribe(IObserver o)
    {
        observers.Add(o);
    }

    public void UnSubscribe(IObserver o)
    {
        observers.Remove(o);
    }
}
