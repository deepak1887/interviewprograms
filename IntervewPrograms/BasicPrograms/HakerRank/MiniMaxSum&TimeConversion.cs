namespace BasicPrograms.HakerRank;
using System.Linq;
public class MiniMaxSum
{
    //private static List<int> minMaxData = new List<int> { 396285104, 573261094, 759641832, 819230764, 364801279 };
    //private static List<int> minMaxData = new List<int> { 5, 5, 5, 5, 5 };
    private static readonly List<int> minMaxData = new List<int> { 1,2,3,4,5 };
    public static void Calculate()
    {
        decimal min = 0, max = 0;
        int indexOfMax = minMaxData.IndexOf(minMaxData.Max());
        int indexOfMin = minMaxData.IndexOf(minMaxData.Min());
        var allMin = minMaxData.ToArray().ToList();
        allMin.RemoveAt(indexOfMax);
        var allMax = minMaxData.ToArray().ToList();
        allMax.RemoveAt(indexOfMin);
        foreach (var val in allMin)
        {
            min += val;
        }
        foreach (var val in allMax)
        {
            max += val;
        }
        Console.WriteLine($"{min} {max}");
    }
}

//Given a time in -hour AM/PM format, convert it to military(24-hour) time.

//Note: - 12:00:00AM on a 12-hour clock is 00:00:00 on a 24-hour clock.
//- 12:00:00PM on a 12-hour clock is 12:00:00 on a 24-hour clock.
public class TimeConversion
{
    private static string s = "12:01:00PM";
    public static void Run()
    {
        Console.WriteLine(s);
        var stringHours = s[..s.IndexOf(':')];
        var prevHours = Convert.ToInt32(stringHours);
        string newHours, result;
        if (s.Contains('P'))
        {
            if (prevHours == 12)
            {
                newHours = "12";
            }
            else
            {
                newHours = (prevHours + 12).ToString();
            }
            s = newHours + s[s.IndexOf(':')..];
            result = s[..(s.Length - 2)];
        }
        else
        {
            if (prevHours == 12)
            {
                newHours = "00";
                s = newHours + s[s.IndexOf(':')..];
            }
            result = s[..(s.Length - 2)];
        }
        Console.WriteLine(result);
    }
}

