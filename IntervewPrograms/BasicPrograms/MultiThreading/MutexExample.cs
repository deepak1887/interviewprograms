namespace BasicPrograms.MultiThreading;
public class MutexExample
{
    public void MutexRun()
    {
        Console.WriteLine("Entering mutex");
        using (var mtx = new Mutex(false, "OnlyAndOnlyOne"))
        {
            if (mtx.WaitOne(5000, false))
            {
                Console.WriteLine("Another instance is runnning");
                Console.ReadLine();
            }
            Console.WriteLine("Application is running");
            FuncDelayed(50, 1);
            Console.ReadLine();
        }
    }

    private void FuncDelayed(int timesRun = 500, int delayInSec = 1)
    {
        for (int i = 0; i < timesRun; i++)
        {
            Thread.Sleep(delayInSec * 1000);
            Console.WriteLine($"delayed {i} output by {delayInSec}");
        }
    }
}
