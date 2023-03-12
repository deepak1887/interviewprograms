namespace DesignPatters.Singleton;
public sealed class Singleton
{
    public int instanceNumber = 0;
    private static Singleton? instance;
    private Singleton()
    {
        instanceNumber++;
    }

    public static Singleton Instance
    {
        get
        {
            instance ??= new Singleton();
            return instance;
        }
    }
}

public sealed class SingletonTS
{
    public int instanceNumber = 0;
    private static volatile SingletonTS? instance;
    private static object lockObject = new Object();
    private SingletonTS()
    {
        instanceNumber++;
    }

    public static SingletonTS Instance
    {
        get
        {
            if(instance == null)
            {
                lock(lockObject)
                {
                    instance ??= new SingletonTS();
                }
            }
            return instance;
        }
    }
}