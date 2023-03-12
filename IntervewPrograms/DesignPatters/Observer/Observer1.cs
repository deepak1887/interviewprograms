namespace DesignPatters.Observer;
public class Observer1 : IObserver
{
    string name;
    public Observer1(string name)
    {
        this.name = name;
    }
    public void Update(int i)
    {
        Console.WriteLine($"alert received by obeserver {name}: alert value: {i}");
    }
}
