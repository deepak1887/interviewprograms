namespace BasicPrograms.MultiThreading;
internal class AsyncAwaitDemo
{

    public static async Task RunAsync()
    {
        var stopWatch = new System.Diagnostics.Stopwatch();
        stopWatch.Start();
        Console.WriteLine($"Main method started with ThreadId {Thread.CurrentThread.ManagedThreadId}");
        await Method1Async();
        await Method2ASync();
        await Method3Async();
        stopWatch.Stop();
        Console.WriteLine($"Main method completed. in {TimeSpan.FromMilliseconds(stopWatch.ElapsedMilliseconds).TotalSeconds}");
    }

    public static async Task RunTplAsync()
    {
        var stopWatch = new System.Diagnostics.Stopwatch();
        stopWatch.Start();
        Console.WriteLine($"Main method started with ThreadId {Thread.CurrentThread.ManagedThreadId}");
        var t1 = Method1Async();
        var t2 = Method2ASync();
        var t3 = Method3Async();
        await Task.WhenAll(t1, t2, t3);
        stopWatch.Stop();
        Console.WriteLine($"Main method completed. in {TimeSpan.FromMilliseconds(stopWatch.ElapsedMilliseconds).TotalSeconds}");
    }

    public static void RunThreadsAsync()
    {
        var threadList = new List<Thread>();
        var stopWatch = new System.Diagnostics.Stopwatch();
        stopWatch.Start();
        Console.WriteLine($"Main method started with ThreadId {Thread.CurrentThread.ManagedThreadId}");
        Thread t1 = new Thread(Method1);
        t1.Start();
        threadList.Add(t1);
        Thread t2 = new Thread(Method2);
        t2.Start();
        threadList.Add(t2);
        Thread t3 = new Thread(Method3);
        t3.Start();
        threadList.Add(t3);
        //threadList.WaitAll();
        stopWatch.Stop();
        Console.WriteLine($"Main method completed. in {TimeSpan.FromMilliseconds(stopWatch.ElapsedMilliseconds).TotalSeconds}");
    }

    private static async Task Method1Async()
    {
        Console.WriteLine($"Method 1 started at {DateTime.UtcNow.ToString("hh:mm:ss")} with ThreadId {Thread.CurrentThread.ManagedThreadId}");
        Task.Delay(4000); // Simulate some asynchronous work
        Console.WriteLine($"Method 1 completed at {DateTime.UtcNow.ToString("hh:mm:ss")} with ThreadId {Thread.CurrentThread.ManagedThreadId}");
    }
    private static void Method1()
    {
        Console.WriteLine($"Method 1 started at {DateTime.UtcNow.ToString("hh:mm:ss")} with ThreadId {Thread.CurrentThread.ManagedThreadId}");
        Thread.Sleep(4000); // Simulate some synchronous work
        Console.WriteLine($"Method 1 completed at {DateTime.UtcNow.ToString("hh:mm:ss")} with ThreadId {Thread.CurrentThread.ManagedThreadId}");
    }

    private static async Task Method2ASync()
    {
        Console.WriteLine($"Method 2 started at {DateTime.UtcNow.ToString("hh:mm:ss")} with ThreadId {Thread.CurrentThread.ManagedThreadId}");
        await Task.Delay(8000); // Simulate some asynchronous work
        Console.WriteLine($"Method 2 completed at {DateTime.UtcNow.ToString("hh:mm:ss")} with ThreadId {Thread.CurrentThread.ManagedThreadId}");
    }

    private static void Method2()
    {
        Console.WriteLine($"Method 2 started at {DateTime.UtcNow.ToString("hh:mm:ss")} with ThreadId {Thread.CurrentThread.ManagedThreadId}");
        Thread.Sleep(8000); // Simulate some synchronous work
        Console.WriteLine($"Method 2 completed at {DateTime.UtcNow.ToString("hh:mm:ss")} with ThreadId {Thread.CurrentThread.ManagedThreadId}");
    }
    private static async Task Method3Async()
    {
        Console.WriteLine($"Method 3 started at {DateTime.UtcNow.ToString("hh:mm:ss")} with ThreadId {Thread.CurrentThread.ManagedThreadId}");
        await Task.Delay(10000); // Simulate some asynchronous work
        Console.WriteLine($"Method 3 completed at {DateTime.UtcNow.ToString("hh:mm:ss")} with ThreadId {Thread.CurrentThread.ManagedThreadId}");
    }

    private static void Method3()
    {
        Console.WriteLine($"Method 3 started at {DateTime.UtcNow.ToString("hh:mm:ss")} with ThreadId {Thread.CurrentThread.ManagedThreadId}");
        Thread.Sleep(10000); // Simulate some synchronous work
        Console.WriteLine($"Method 3 completed at {DateTime.UtcNow.ToString("hh:mm:ss")} with ThreadId {Thread.CurrentThread.ManagedThreadId}");
    }

    public static async Task RunMultipleTaskAtATime()
    {
        var stopWatch = new System.Diagnostics.Stopwatch();
        stopWatch.Start();
        var tasks = new Task[10];
        for (int i = 0; i < tasks.Length; i++)
        {
            tasks[i] = Task.Run(() =>
            {
                Console.WriteLine($"Task {i} started at {DateTime.UtcNow.ToString("hh:mm:ss")} with ThreadId {Thread.CurrentThread.ManagedThreadId}");
                Thread.Sleep(2000); // Simulate some work
                Console.WriteLine($"Task {i} completed at {DateTime.UtcNow.ToString("hh:mm:ss")} with ThreadId {Thread.CurrentThread.ManagedThreadId}");
            });
        }

        await Task.WhenAll(tasks);
        stopWatch.Stop();
        Console.WriteLine($"Main method completed. in {TimeSpan.FromMilliseconds(stopWatch.ElapsedMilliseconds).TotalSeconds}");
    }
}

public static class ThreadExtension
{
    public static void WaitAll(this IEnumerable<Thread> threads)
    {
        if (threads != null)
        {
            foreach (Thread thread in threads)
            { thread.Join(); }
        }
    }
}
