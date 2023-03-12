namespace ConstructorInterview.QSSCorp
{
    public static class QssWritten
    {
        //1.Suppose you have an array with following data
        // 10,30,50,24,11,8,19,90,40,60
        //output logic [1stLowest, 1st top, 2nd lowest, 2nd top, 3rd lowest, 3rd top]
        //write a program to arrange an array in following sequence
        //result ---8,90,10,60,11,50,19,40,24,30
        private static readonly int[] intArray = new int[] { 2, 3, 4, 58, 5, 6, 7, 2, 5, 12 };
        public static void ArrangeArray()
        {
            int[] intArray = new int[] { 10, 30, 50, 24, 11, 8, 19, 90, 40, 60 };
            int[] result = new int[10];
            var accending = intArray.OrderBy(i => i).ToArray();
            int arraylength = accending.Length - 1;
            int begining = 0;
            //var desceding = intArray.OrderByDescending(i => i).ToArray();
            for (int i = 0; i < intArray.Length; i++)
            {
                if (i % 2 == 0)
                    result[i] = accending[begining++]; //0,2,4,6--
                else
                    result[i] = accending[arraylength--]; //1,3,5,7----0,1,2,3,4
            }
            foreach (int i in result)
                Console.Write(i + " ");

            Console.ReadLine();
        }

        public static void UniqueNumber()
        {

            var result = intArray.Distinct();
            foreach (int i in result)
                Console.Write(i + " ");
            Console.ReadLine();
        }

        public static int FindLargest(int whichLargest)
        {
            if (whichLargest < 1)
            {
                return 0;
            }
            return intArray.OrderByDescending(x => x).Take(whichLargest).Reverse().First();
        }
        public static string ReverseOfString(string str)
        {
            string reverse = "";
            for (int i = str.Length - 1; i >= 0; i--)
            {
                reverse += str[i];
            }
            return reverse;
        }




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
    }
}
