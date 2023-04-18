namespace BasicPrograms.HakerRank;
public class HakerRankDemo
{
    public static void Run()
    {
        while (true)
        {
            Console.WriteLine("This part includes solution for HakerRank problems");
            Console.WriteLine("1. Print Min Max Sum");
            Console.WriteLine("2. Time Conversion ");
            Console.WriteLine("3. Breaking the Records");
            Console.WriteLine("4. Camel Case");
            Console.WriteLine("5. Divisible Sum Pairs");
            Console.WriteLine("6. Sparse Arrays");
            Console.WriteLine("7. Lonely Integer");
            Console.WriteLine("9. To go back");
            int i = Convert.ToInt32(Console.ReadLine());
            switch (i)
            {
                case 1:
                    MiniMaxSum.Calculate();
                    break;
                case 2:
                    TimeConversion.Run();
                    break;
                case 3:
                    BreakingTheRecords.Run();
                    break;
                case 4:
                    CamelCase.Run();
                    break;
                case 5:
                    DivisibleSumPairs.Run();
                    break;
                case 6:
                    SparseArrays.Run();
                    break;
                case 7:
                    LonelyInteger.Run();
                    break;
                default:
                    break;
            }
            if (i == 9)
            {
                break;
            }
        }
    }
}


