namespace Problems;
public class NumberOperation
{
    public static void RevInteger()
    {
        Console.WriteLine("Enter Number to reverse");
        int number = Convert.ToInt32(Console.ReadLine());
        int temp = 0;

        while (number != 0)
        {
            temp = temp * 10 + number % 10;
            number /= 10;
        }
        Console.Write(temp);
        Console.ReadLine();
    }

    public void Factorial()
    {
        Console.WriteLine("Enter Number to calculate factorial");
        int number = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(CalculateFactorial(number));
        Console.ReadKey();
    }

    public int CalculateFactorial(int number)
    {
        if (number == 0)
        {
            return 1;
        }
        else
        {
            return number * CalculateFactorial(number - 1);
        }
    }


}