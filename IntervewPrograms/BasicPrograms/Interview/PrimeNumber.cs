namespace BasicPrograms.Interview;
public class PrimeNumber
{
    public static int GetPrimeNumber(int position)
    {
        int num = 1;
        int primePosition = 0;
        while (true)
        {
            num++;
            if (IsPrime(num))
            {
                primePosition++;
            }
            if (primePosition == position)
            {
                break;
            }
        }
        return num;
    }
    public static int[] GetPrimeNumbers(int[] positions)
    {
        int num = 1;
        int primePosition = 0;
        var primeNumbers = new List<int>();
        while (true)
        {
            if (IsPrime(num))
            {
                primePosition++;
                if (positions.Any(x => x == primePosition))
                {
                    primeNumbers.Add(num);
                }
            }
            if (primeNumbers.Count == positions.Length)
            {
                break;
            }
        }
        return primeNumbers.ToArray();
    }
    private static bool IsPrime(int number)
    {
        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0) return false;
        }
        return true;
    }
}
