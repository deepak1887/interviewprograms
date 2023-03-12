namespace DesignPatters.Observer;
public class ObserverDemo
{
    public static void Start()
    {
        Console.WriteLine("Setting up observer 1");
        var observer1 = new Observer1("Observer 1");
        Console.WriteLine("Setting up observer 2");
        var observer2 = new Observer1("Observer 2");
        Console.WriteLine("Setting up observer 3");
        var observer3 = new Observer1("Observer 3");
        Console.WriteLine("Setting up Subject");
        var subject = new Subject();
        subject.Subscribe(observer1);
        subject.Subscribe(observer2);
        subject.Subscribe(observer3);
        Console.WriteLine("Update flag to 1");
        subject.Flag = 1;
        Console.WriteLine("Update flag to 2");
        subject.Flag = 2;
        Console.WriteLine("Update flag to 3");
        subject.Flag = 3;
        Console.WriteLine("Update flag to 4");
        subject.Flag = 4;
    }
}
