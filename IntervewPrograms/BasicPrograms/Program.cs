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
