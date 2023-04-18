namespace Problems;
public class ProblemsDemo
{
    
    public static void Run()
    {
        while (true)
        {
            Console.WriteLine("This part includes solution for below problems");
            Console.WriteLine("1. Check if the number Prime number");
            Console.WriteLine("2. Print Prime numbers from 0 to ");
            Console.WriteLine("3. Print Prime numbers poistions from 0 to ");
            Console.WriteLine("4. Factorial");
            Console.WriteLine("5. Print reverse of the integer");
            Console.WriteLine("9. To go back");
            int i = Convert.ToInt32(Console.ReadLine());
            switch (i)
            {
                case 1:
                    NumberOperation.CheckPrime();
                    break;
                case 2:
                    NumberOperation.PrintPrimeNoRange();
                    break;
                case 3:
                    NumberOperation.PrintPrimePositions();
                    break;
                case 4:
                    NumberOperation.Factorial();
                    break;
                case 5:
                    NumberOperation.RevInteger();
                    break;
                default:
                    break;
            }
            if(i == 9)
            {
                break;
            }
           
        }
    }
}
