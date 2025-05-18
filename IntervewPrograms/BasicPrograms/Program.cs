// See https://aka.ms/new-console-template for more information
using BasicPrograms.Delegates;
using BasicPrograms.HakerRank;
using BasicPrograms.Interfaces;
using BasicPrograms.MultiThreading;
using Problems;

while (true)
{
    Console.WriteLine("Press corrosponding no to go to below sections");
    Console.WriteLine("1. Delegate");
    Console.WriteLine("2. Interfaces");
    Console.WriteLine("3. Numerical problems");
    Console.WriteLine("4. Pyramid problems");
    Console.WriteLine("5. String problems");
    Console.WriteLine("6. Multi Threading");
    Console.WriteLine("7. Haker Rank problems");
    Console.WriteLine("8. Unique problems");
    Console.WriteLine("9. Async Await- all await separately");
    Console.WriteLine("10. Async Await- when all await at same time");
    Console.WriteLine("11. Async Await- when all run in separate thread");
    int i = Convert.ToInt32(Console.ReadLine());

    switch (i)
    {
        case 1:
            Console.WriteLine("\n");
            DelegatesDemo.Run();
            break;
        case 2:
            Console.WriteLine("\n");
            InterfaceDemo.Run();
            break;
        case 3:
            Console.WriteLine("\n");
            ProblemsDemo.Run();
            break;
        case 4:
            Console.WriteLine("\n");
            PyramidDemo.Run();
            break;
        case 5:
            Console.WriteLine("\n");
            StringOperationDemo.Run();
            break;
        case 6:
            Console.WriteLine("\n");
            MultiThreadingDemo.Run();
            break;
        case 7:
            Console.WriteLine("\n");
            HakerRankDemo.Run();
            break;
        case 8:
            Console.WriteLine("\n");
            Uniques.Run();
            break;
        case 9:
            Console.WriteLine("\n");
            AsyncAwaitDemo.RunAsync().GetAwaiter();
            break;
        case 10:
            Console.WriteLine("\n");
            AsyncAwaitDemo.RunTplAsync().GetAwaiter();
            break;
        case 11:
            Console.WriteLine("\n");
            AsyncAwaitDemo.RunThreadsAsync();
            break;
        case 12:
            Console.WriteLine("\n");
            AsyncAwaitDemo.RunMultipleTaskAtATime().GetAwaiter();
            break;
        default:
            break;
    }
    Console.WriteLine("To start again press any key");
    Console.ReadKey();
    Console.Clear();
    //if(Convert.ToInt32(Console.ReadLine()) == 0)
    //{
    //    break;
    //}
}
//Console.ReadLine();

class Bob
{
    public int Number { get; set; }
}
