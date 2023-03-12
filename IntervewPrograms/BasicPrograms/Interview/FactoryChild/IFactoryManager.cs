namespace BasicPrograms.Interview.FactoryChild;
public interface IFactoryManager
{
    void Display();
}

public class ChildB : IFactoryManager
{
    public void Display()
    {
        Console.WriteLine("From ChildB");
    }
}

public class ChildA : IFactoryManager
{
    public void Display()
    {
        Console.WriteLine("From ChildA");
    }
}