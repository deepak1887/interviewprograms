namespace BasicPrograms.HakerRank;

//Given an array of integers and a positive integer k, determine the number of (i, j) pairs where i<j  and  arr[i]+ arr[j] is divisible by k.
//Example
// arr=[1,2,3,4,5,6]
// k= 5
//Three pairs meet the criteria: [1,4], [2,3]  and [4,6].
//Function Description
//Complete the divisibleSumPairs function in the editor below.
//divisibleSumPairs has the following parameter(s):
//int n: the length of array
//int ar[n]: an array of integers
//int k: the integer divisor
public class DivisibleSumPairs
{
    private static int[] ar = new int[] { 1, 3, 2, 6, 1, 2 };
    public static void Run()
    {
        Console.WriteLine($"Sample date {string.Join(',', ar)}");
        int k = 3;

        int position = 0;
        var result = new List<(int, List<int>)>();
        while (position < ar.Length)
        {
            result.Add((ar[position], Match(position, ar, k)));
            position++;

        }
        var allValues = new List<(int, int)>();
        foreach (var item in result)
        {
            foreach (var pair in item.Item2)
            {
                allValues.Add((item.Item1, pair));
                Console.Write($"Pairs [{item.Item1}, {pair}] ");
            }
        }
        Console.WriteLine();
        Console.WriteLine($"Total Pair count {allValues.Count}"); 
    }

    private static List<int> Match(int start, int[] arr, int divisor)
    {
        var match = new List<int>();
        for (int i = start + 1; i < arr.Length; i++)
        {
            if ((arr[start] + arr[i]) % divisor == 0)
            {
                match.Add(arr[i]);
            }
        }
        return match;
    }
}

//There is a collection of input strings and a collection of query strings.For each query string,
//determine how many times it occurs in the list of input strings.Return an array of the results.
//Example
// strings = ['ab', 'ab', 'abc']
// queries = ['ab', 'abc', 'bc']


//There are 2 instances of 'ab',1  of 'abc' and 0 of 'bc'. For each query, add an element to the return array, .
// result = [2,1,0]
public class SparseArrays
{
    private static string[] strings = new string[] { "ab", "ab", "abc" };
    private static string[] queries = new string[] { "ab", "abc", "bc" };

    public static void Run()
    {
        Console.WriteLine($"strings: {string.Join(", ", strings)}");
        Console.WriteLine($"queries: {string.Join(", ", queries)}");
        var items = MatchingStrings(strings, queries);
    }
    public static List<int> MatchingStrings(string[] strings, string[] queries)
    {

        var result = new List<(string, int)>();
        foreach (var query in queries)
        {
            int count = 0;
            for (int i = 0; i < strings.Length; i++)
            {
                if (query == strings[i])
                {
                    count++;
                }
            }
            result.Add((query, count));
            Console.WriteLine($"Result : query {query} count {count}");
        }
        return result.Select(r => r.Item2).ToList();
    }
}
