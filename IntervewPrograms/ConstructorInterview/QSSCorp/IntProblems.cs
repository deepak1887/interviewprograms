namespace ConstructorInterview.QSSCorp
{
    public static class IntProblems
    {
        //reverse a string
        public static void ReverseOfString(string str)
        {
            var charArray = str.ToCharArray().Reverse();
            Console.WriteLine(string.Join("", charArray));
        }
        public static string ReturnReverseOfString(string str)
        {
            var charArray = str.ToCharArray().Reverse();
            return string.Join("", charArray);
        }
        //largest integer
        public static void FindLargestInteger(int number)
        {
            int reminder = 0, largest = 0;
            while (number > 0)
            {
                reminder = number % 10;
                if (largest < reminder)
                {
                    largest = reminder;
                }
                number = number / 10;
            }

            Console.WriteLine(largest);
        }
        //palindrome test
        public static void PalinDrome(int number)
        {
            int temp, reverse = 0, reminder;
            temp = number;
            while (number > 0)
            {
                reminder = number % 10;
                reverse = (reverse * 10) + reminder;
                number = number / 10;
            }
            if (temp == reverse)
            {
                Console.WriteLine("The number is palindrome");
            }
            else
            {
                Console.WriteLine("The number is not palindrome");

            }
        }

        //reverse each word of string
        public static void ReverseStringInLine(string line)
        {
            string[] strArray = line.Split(' ');
            for (int i = 0; i <= strArray.Length - 1; i++)
            {
                strArray[i] = ReturnReverseOfString(strArray[i]);
            }

            Console.WriteLine(string.Join(" ", strArray));
        }

        //reverse word with reverse order
        public static void ReverseStringInReverseOrder(string line)
        {
            string[] strArray = line.Split(' ');
            for (int i = 0; i <= strArray.Length - 1; i++)
            {
                strArray[i] = ReturnReverseOfString(strArray[i]);
            }

            Console.WriteLine(string.Join(" ", strArray.Reverse()));
        }

        public static void CountOccurenceInString(string str)
        {
            Dictionary<char, int> pairs = new Dictionary<char, int>();
            foreach (char value in str.ToCharArray())
            {
                if (!pairs.ContainsKey(value))
                {
                    pairs.Add(value, 1);
                }
                else
                {
                    pairs[value]++;
                }
            }
            foreach (var value in pairs)
            {
                Console.WriteLine($"{value.Key} is repeated {value.Value} times.");
            }
        }

        public static void RemoveDuplicateFromString(string str)
        {
            List<char> result = new List<char>();
            foreach (char value in str)
            {
                if (!result.Contains(value))
                {
                    result.Add(value);
                }
            }

            Console.WriteLine(string.Join("", result));
        }
        //missing numbers in array
        public static void MisssingNumberInArray()
        {
            int[] array = Enumerable.Range(1, 90).ToArray();
            int counter = 1;
            while (counter <= 100)
            {
                if (!array.Contains(counter))
                {
                    Console.Write(counter);
                }
                counter++;
            }
        }

        //Sort Array
        public static void SortArray(int[] array)
        {
            foreach (int i in array)
            {
                int currentIndex = Array.IndexOf(array, i);
                for (int j = 0; j < currentIndex; j++)
                {
                    if (array[j] > i)
                    {
                        SwapCurrent(array, currentIndex);
                        SortArray(array);
                    }
                }
            }
        }

        private static void QuickSort(int low, int high, int[] array)
        {
            int i = low;
            int j = high;
            //mid index
            int piviot = array[low + (high - low) / 2];

            while (i < j)
            {
                while (array[i] < piviot)
                {
                    i++;
                }
                while (array[j] > piviot)
                {
                    j--;
                }
                if (i <= j)
                {
                    SwapPrevious(array, i, j);
                    i++;
                    j--;
                }
            }
            if (low < j) { SwapPrevious(array, low, j); }
            if (i < high) { SwapPrevious(array, i, high); }
            array.ToList().ForEach(x => Console.Write(x));
        }

        private static void SwapPrevious(int[] array, int currentIndex, int swapTo)
        {
            //int currentIndex = Array.IndexOf(array, element);
            int temp = array[swapTo];
            array[swapTo] = array[currentIndex];
            array[currentIndex] = temp;
        }
        private static void SwapCurrent(int[] array, int currentIndex)
        {
            //int currentIndex = Array.IndexOf(array, element);
            int temp = array[currentIndex - 1];
            array[currentIndex - 1] = array[currentIndex];
            array[currentIndex] = temp;
        }

        //LeftCircularRotation of a number
        public static void LeftCircularRotation(int number, int timesRotation)
        {
            while (timesRotation > 0)
            {
                number = RotateRight(number);
                timesRotation--;
            }
            Console.WriteLine(number);
        }

        public static int RotateRight(int number)
        {
            List<int> resultArray = new List<int>();
            while (number > 0)
            {
                resultArray.Add(number % 10);
                number /= 10;
            }

            resultArray.Reverse();
            int temp = resultArray[resultArray.Count - 1];
            for (int i = resultArray.Count - 2; i >= 0; i--)
            {
                resultArray[i + 1] = resultArray[i];
            }
            resultArray[0] = temp;
            return ConstructNumber(resultArray);
        }

        private static int ConstructNumber(List<int> numbers)
        {
            int result = 0;
            foreach (int i in numbers)
            {
                result = (result * 10) + i;
            }
            return result;
        }

        public static void GetDayFromDate()
        {
            DateTime inputDate = new DateTime(2019, 7, 7);
            Console.Write($"day: {inputDate.DayOfWeek}, month: {inputDate.Month}");
        }

        public static void printPyramid(int height)
        {
            int level = 1;

            while (level <= height)
            {
                string text = string.Join("", Enumerable.Repeat("*", level));
                Console.WriteLine(text.PadRight(height - level + text.Length));
                level++;
            }
        }

        public static void PrintNumber(int number)
        {
            string[] hundred = new string[] { "one hundred", "two hundred", "three hundred", "four hundred", "five hundred", "six hundred", "seven hundred", "eight hundred", "nine hundred" };
            string[] tens = new string[] { "ten", "twenty", "thrity", "fourty", "fifty", "sixty", "seventy", "eighty", "ninty" };
            string[] ones = new string[] { "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            List<int> numbers = new List<int>();
            while (number > 0)
            {
                numbers.Add(number % 10);
                number = number / 10;
            }

            for (int i = numbers.Count - 1; i >= 0; i--)
            {
                int num = numbers[i] - 1;
                if (num < 0)
                {
                    continue;
                }
                if (i == 0)
                {
                    Console.Write(ones[num] + " ");
                }
                if (i == 1)
                {
                    Console.Write(tens[num] + " ");
                }
                if (i == 2)
                {
                    Console.Write(hundred[num] + " ");
                }
            }
        }

    }
}
