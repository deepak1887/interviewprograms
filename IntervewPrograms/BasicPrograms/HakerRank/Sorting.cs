namespace BasicPrograms.HakerRank;
internal class Sorting
{
    public static T[] SortAscending<T>(T[] elements) where T : struct
    {
        T temp;
        if (typeof(T) == typeof(int))
        {

            for (int i = 0; i < elements.Length; i++)
            {
                for (int j = i + 1; j < elements.Length; j++)
                {
                    if (Convert.ToInt32(elements[i]) > Convert.ToInt32(elements[j]))
                    {
                        temp = elements[j];
                        elements[j] = elements[i];
                        elements[i] = temp;
                    }
                }
            }

            return elements;
        }

        if (typeof(T) == typeof(string))
        {

            for (int i = 0; i < elements.Length; i++)
            {
                for (int j = i + 1; j < elements.Length; j++)
                {
                    if (elements[i].ToString()?.CompareTo(elements[j].ToString()) > 0)
                    {
                        temp = elements[j];
                        elements[j] = elements[i];
                        elements[i] = temp;
                    }
                }
            }
            return elements;
        }

        throw new NotSupportedException();

    }
}

internal class Uniques
{

    private static int[] elements = { 1, 1, 2, 3, 4, 4, 5, 5, 6, 7,99 };

    public static int[] GetUniques(int[] numbers)
    {
        int n = numbers.Length;

        // Step 1: Find min and max for efficient array sizing
        int min = int.MaxValue;
        int max = int.MinValue;
        for (int i = 0; i < n; i++)
        {
            if (numbers[i] < min) min = numbers[i];
            if (numbers[i] > max) max = numbers[i];
        }

        // Step 2: Create a count array based on the range (size = max - min + 1)
        int range = max - min + 1;
        int[] count = new int[range];

        for (int i = 0; i < n; i++)
        {
            count[numbers[i] - min]++;
        }

        // Step 3: Collect unique numbers (count == 1)
        int uniqueCount = 0;
        for (int i = 0; i < n; i++)
        {
            if (count[numbers[i] - min] == 1)
            {
                uniqueCount++;
            }
        }

        int[] result = new int[uniqueCount];
        int index = 0;
        for (int i = 0; i < n; i++)
        {
            if (count[numbers[i] - min] == 1)
            {
                result[index++] = numbers[i];
            }
        }

        return result;
        //int n = elements.Length;
        //bool[] duplicates = new bool[n];
        //for (int i = 0; i < n; i++)
        //{
        //    if (duplicates[i]) continue;
        //    for (int j = 0; j < n; j++)
        //    {
        //        if(i != j && elements[i] == elements[j])
        //        {
        //            duplicates[i] = true;
        //            duplicates[j] = true;
        //        }
        //    }
        //}

        ////calculate the lsize of array
        //int uniqueCount = 0;
        //foreach (var duplicate in duplicates)
        //{
        //    if (!duplicate)
        //    {
        //        uniqueCount++;
        //    }
        //}

        //int[] result = new int[uniqueCount];
        //int index = 0;
        //for (int i = 0; i < n; i++)
        //{
        //    if (!duplicates[i])
        //    {
        //        result[index++] = elements[i];
        //    }
        //}

        //return result;
    }

    public static void Run()
    {
        Console.WriteLine($"Getting uniques of :{string.Join(',', elements)}");
        var result = GetUniques(elements);
        Console.WriteLine($"Unique elements are : {string.Join(',', result)}");
    }
}
