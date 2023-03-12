namespace ConstructorInterview.Pyramid
{
    public class FibonachiSeries
    {
        public static void Run()
        {
            int start = 0, next = 1, increment = 1, number = 10;
            Fibonacci(start, next, increment, number);

        }
        public static void Fibonacci(int start, int next, int increment, int number)
        {
            Console.WriteLine(start);
            if (increment < number) Fibonacci(next, start + next, increment + 1, number);
        }

    }
}
