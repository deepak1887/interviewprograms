namespace ConstructorInterview.QSSCorp
{
    public static class HappyNumber
    {
        //A number is happy if the sum of the square of the digits ever equals one.
        static int testTimes = 0;
        public static void RunHappyTest(int number)
        {
            Console.WriteLine(IsHappy(number));
        }

        static bool IsHappy(int number)
        {
            if (number == 1)
                return true;
            if (number < 1)
                return false;
            if (testTimes == 10)
            {
                return false;
            }
            int sum = 0, reminder;
            while (number > 0)
            {
                reminder = number % 10;
                sum += (reminder * reminder);
                number /= 10;
            }
            testTimes++;
            return IsHappy(sum);
        }
    }
}
