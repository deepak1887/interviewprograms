namespace Problems;
public class NumberOperation
{
    public static bool Armstrong(int number)
    {
        int temp, reverse = 0, reminder;
        temp = number;
        while (number > 0)
        {
            reminder = number % 10;
            reverse += (reminder * reminder * reminder);
            number = number / 10;
        }
        return temp == reverse;
    }
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

    public static void Factorial()
    {
        Console.WriteLine("Enter Number to calculate factorial");
        int number = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(CalculateFactorial(number));
        Console.ReadKey();
    }

    private static int CalculateFactorial(int number)
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

    private static void PrintAllPrimeNumerInArray(int[] numbers)
    {
        var primeNumbers = new List<int>();
        foreach (int number in numbers)
        {
            if (IsPrimeNumber(number))
            {
                primeNumbers.Add(number);
            }
        }
        Console.WriteLine(string.Join(", ", primeNumbers.ToArray()));
    }

    private static void PrintAllPrimePosition(int[] numbers)
    {
        var primeNumbers = new List<int>();
        for (int i = 0; i < numbers.Length; i++)
        {
            if (IsPrimeNumber(i))
            {
                primeNumbers.Add(numbers[i]);
            }
        }
        Console.WriteLine(string.Join(", ", primeNumbers.ToArray()));
    }

    private static bool IsPrimeNumber(int number)
    {
        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0) return false;
        }
        return true;
    }

    public static void CheckPrime()
    {
        Console.WriteLine("Enter the number to check prime number");
        int number = Convert.ToInt32(Console.ReadLine());
        var result = IsPrimeNumber(number);
        if (result) Console.WriteLine($"{number} is a prime number");
        else Console.WriteLine($"{number} is not a prime number");
    }

    public static void PrintPrimeNoRange()
    {
        Console.WriteLine("Please enter the end limit greater then 1");
        int limit = Convert.ToInt32(Console.ReadLine());
        var numbers = new List<int>();
        for (int j = 0; j <= limit; j++)
        {
            numbers.Add(j);
        }
        PrintAllPrimeNumerInArray(numbers.ToArray());
    }

    public static void PrintPrimePositions()
    {
        Console.WriteLine("Please enter the end limit greater then 1");
        int limit = Convert.ToInt32(Console.ReadLine());
        var numbers = new List<int>();
        for (int j = 0; j <= limit; j++)
        {
            numbers.Add(j);
        }
        PrintAllPrimeNumerInArray(numbers.ToArray());
    }

    public static void PrintMaxElementFromArray(int[] inputs)
    {
        int max = inputs[0];
        for (int i = 1; i < inputs.Length; i++)
        {
            if (inputs[i] > max)
            {
                max = inputs[i];
            }
        }
        Console.WriteLine($"Max element is {max}");
    }

}