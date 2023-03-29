namespace BasicPrograms.MultiThreading;
internal class MultiThreadingDemo
{
    public static void Run()
    {
        //for (int i = 0; i < 10; i++)
        //{
        //    var callback = new WaitCallback(Print);
        //    ThreadPool.QueueUserWorkItem( callback );
        //    Console.WriteLine($"max available threads {ThreadPool.ThreadCount}");
        //}
        //Console.ReadLine();
        Console.WriteLine("Creatig thread 1");
        var t1 = new Thread(new ThreadStart(FuncDelayed1));
        
        Console.WriteLine("Creatig thread 2");
        var t2 = new Thread(new ThreadStart(FuncDelayed2));
        Console.WriteLine("starting thread 1");
        t1.Name = "Thread 1";
        t1.Start();
        Console.WriteLine("starting thread 1");
        t2.Name = "Thread 2";
        t2.Start();
        Console.WriteLine("Main Thread");
        Console.ReadLine();


        //Console.WriteLine("Mutex Example");
        //var mut1 = new MutexExample();
        //mut1.MutexRun();
        //Thread.Sleep(8000);
        //mut1.MutexRun();
        //Console.ReadLine() ;
    }

    private static void FuncDelayed(int timesRun = 500, int delayInSec = 1)
    {
        for (int i = 0; i < timesRun; i++)
        {
            Thread.Sleep(delayInSec * 1000);
            Console.WriteLine($"delayed {i} output by {delayInSec} from thread {Thread.CurrentThread.ManagedThreadId}");
        }
    }
    private static void FuncDelayed1()
    {
        FuncDelayed(500, 1);
    }
    private static void FuncDelayed2()
    {
        FuncDelayed(500, 2);
    }

    public static void Print(object o)
    {
        FuncDelayed(10);
    }
}
