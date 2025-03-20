namespace BasicPrograms.HakerRank;
public class PermutingTwoArrays
{
    private static int[] A = { 1, 2, 2, 1 };
    private static int[] B = { 3, 3, 3, 4 };
    private static int k = 5;
    public static void Run()
    {
        Console.WriteLine($"input A : {string.Join(",", A.ToArray())}");
        Console.WriteLine($"input B : {string.Join(",", B.ToArray())}");
        Console.WriteLine("Constant: " + k);
        Console.WriteLine(TwoArrays(k, A.ToList(), B.ToList()));
    }
    private static string TwoArrays(int k, List<int> A, List<int> B)
    {
        A.Sort((a, b) => a - b);
        B.Sort((a, b) => b - a);
        for (int i = 0; i < A.Count; i++)
        {
            if (A[i] + B[i] < k)
            {
                return "NO";
            }
        }
        return "YES";
    }
}


//Two children, Lily and Ron, want to share a chocolate bar.Each of the squares has an integer on it.
//Lily decides to share a contiguous segment of the bar selected such that:
//1. The length of the segment matches Ron's birth month, and,
//2. The sum of the integers on the squares is equal to his birth day.
//Determine how many ways she can divide the chocolate.
//Example
// s = [2,2,1,3,2]
// d =4
// m =2
//Lily wants to find segments summing to Ron's birth day, d=4 with a length equalling his birth month, m=2. In this case, there are two segments meeting her criteria: [2,2] and [1,3].

public class SubarrayDivision2
{

}
