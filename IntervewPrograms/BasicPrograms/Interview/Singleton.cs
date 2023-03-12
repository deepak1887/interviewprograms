namespace BasicPrograms.Interview;
public sealed class Singleton
{
    private readonly static Object obj = new();
    private Singleton()
    {
        Console.WriteLine("Singleton constructor created");
    }
    private static Singleton instance = null;
    public static Singleton GetInstance()
    {
        lock (obj)
        {
            if (instance == null)
            {
                instance = new Singleton();
            }
        }

        return instance;
    }
}
