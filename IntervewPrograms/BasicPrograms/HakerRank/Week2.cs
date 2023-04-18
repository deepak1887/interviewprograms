using static BasicPrograms.AnanomusFuntions;
using System.Collections.Generic;
using System.Numerics;
using System.Reflection.Emit;
using System.Reflection.Metadata;
using System.Security.Claims;
using System.Text;
using System;
using BasicPrograms.Interfaces;
using static System.Net.Mime.MediaTypeNames;
using System.Data.Common;
using System.Reflection;
using System.IO;
using System.Threading.Channels;

namespace BasicPrograms.HakerRank;
//Given an array of integers, where all elements but one occur twice, find the unique element.
//Example
// a = [1,2,3,4,3,2,1]
//The unique element is .
public class LonelyInteger
{
    static readonly int[] a = new int[] { 1, 2, 3, 4, 3, 2, 1 };
    public static void Run()
    {
        Console.WriteLine($"input array a: {string.Join(",", a)}");
        var unique = a.Where(s => s > 0 && s < 100).GroupBy(x => x).Where(grp => grp.Count() == 1).First().Key;
        Console.WriteLine($"Unique element is: {unique}");
    }
}


//HackerLand University has the following grading policy:

//Every student receives a grade in the inclusive range from 0 to 100.
//Any grade less than 40 is a failing grade.
//Sam is a professor at the university and likes to round each student's grade according to these rules:

//If the difference between the grade and the next multiple of 5 is less than 3, round grade up to the next multiple of 5.
//If the value of grade is less than 38, no rounding occurs as the result will still be a failing grade.
//Examples

//grade = 84 round to  (85 - 84 is less than 3)
//grade = 29 do not round(result is less than 40)
//grade = 57 do not round(60 - 57 is 3 or higher)
//Given the initial value of grade for each of Sam's n students, write code to automate the rounding process.
public class GradingStudent
{
    //First element represents length of array
    public static List<int> grades = new() { 4, 73, 67, 38, 33 };

    public static void Run()
    {
        for (int i = 1; i < grades.Count; i++)
        {
            if (grades[i] >= 38)
            {
                int next = NextMultiple(grades[i], 5);
                if ((next - grades[i]) < 3)
                {
                    grades[i] = next;
                }
            }
        }
        Console.WriteLine(string.Join(",", grades.Skip(1)));
    }

    static int NextMultiple(int value, int multiple)
    {
        return value + (multiple - value % multiple);
    }
}

//You will be given a list of 32 bit unsigned integers. Flip all the bits ( 1-> 0 and 0 -> 1) and return the result as an unsigned integer.
//Example
// n =9 base 10
// 9 base 10 = 1001 base 2
//0000000000000000000000000000001001 base 2 = 9 base 10;
//1111111111111111111111111111111110 base 2 = 4294967286 base 10
//. We're working with 32 bits, so:
//Return . 4294967286
//Function Description
//Complete the flippingBits function in the editor below.
//flippingBits has the following parameter(s):
//int n: an integer
//Returns
//int: the unsigned decimal integer result

public class FlippingBits
{
    private static readonly long number = 9;

    public static void Run()
    {
        Console.WriteLine("Input value : " + number);
        var base2String = Convert.ToString(number, 2).PadLeft(32, '0');
        Console.WriteLine("Base 2 string : " + base2String);
        var flipBits = base2String.ToCharArray().Select(x =>
        {
            if (x == '0') return '1';
            else return '0';
        }).ToArray();
        var converted = Convert.ToInt64(new string(flipBits));
    }
}

//Given a square matrix, calculate the absolute difference between the sums of its diagonals.
//For example, the square matrix arr is shown below:
//1 2 3
//4 5 6
//9 8 9
//The left-to-right diagonal = 1+5+9 = 15. The right to left diagonal = 3+5+9=17 . Their absolute difference is |15-17| = 2.
public class DiagonalDifference
{
    private static List<List<int>> matrix = new()
                                    {
                                        new List<int>(){11,2,4},
                                        new List<int>(){4,5,6},
                                        new List<int>(){10,8,-12},
                                    };
    public static void Run()
    {
        var length = matrix.Count;
        var secondLength = length - 1;
        int start = 0, firstDiagonal = 0, SecondDiagonal = 0;
        while (length > start)
        {
            firstDiagonal += matrix[start][start];
            SecondDiagonal += matrix[start][secondLength];
            start++;
            secondLength--;
        }
        Console.WriteLine("Sample input");
        foreach (var i in matrix)
        {
            Console.WriteLine($"| {string.Join(" ", i)} |");
        }
        Console.WriteLine("Left to right Sum :" + firstDiagonal);
        Console.WriteLine("right to left Sum :" + SecondDiagonal);
        Console.WriteLine("Absolute difference : " + Math.Abs(firstDiagonal - SecondDiagonal));

    }

}

public class CountingSort
{
    private static readonly List<int> numArray = new List<int>()
    {
    63, 25, 73, 1, 98, 73, 56, 84, 86, 57, 16, 83, 8, 25, 81, 56, 9, 53, 98, 67, 99, 12, 83, 89, 80, 91, 39, 86, 76, 85, 74, 39, 25, 90, 59, 10, 94, 32, 44, 3, 89, 30, 27, 79, 46, 96, 27, 32, 18, 21, 92, 69, 81, 40, 40, 34, 68, 78, 24, 87, 42, 69, 23, 41, 78, 22, 6, 90, 99, 89, 50, 30, 20, 1, 43, 3, 70, 95, 33, 46, 44, 9, 69, 48, 33, 60, 65, 16, 82, 67, 61, 32, 21, 79, 75, 75, 13, 87, 70, 33
    };

    public static void Run()
    {
        Console.WriteLine($"Input array length {numArray.Count}");
        Console.WriteLine(string.Join(" ", numArray));
        var returningArr = new int[numArray.Count]; // have constraint for 100 in original solution
        for (int i = 0; i < numArray.Count; i++)
        {
            returningArr[numArray[i]]++;
        }
        Console.WriteLine("Result :");
        Console.WriteLine(string.Join(" ", returningArr));
    }
}

//An avid hiker keeps meticulous records of their hikes.During the last hike that took exactly steps steps, for every step it was noted if it was an uphill, U, or a downhill,D step. Hikes always start and end at sea level, and each step up or down represents a 1 unit change in altitude.We define the following terms:

//A mountain is a sequence of consecutive steps above sea level, starting with a step up from sea level and ending with a step down to sea level.
//A valley is a sequence of consecutive steps below sea level, starting with a step down from sea level and ending with a step up to sea level.
//Given the sequence of up and down steps during a hike, find and print the number of valleys walked through.
//Example
// steps = 8 path = [DDUUUUDD]
//The hiker first enters a valley 2 units deep.Then they climb out and up onto a mountain 2 units high.Finally, the hiker returns to sea level and ends the hike.
//Function Description
//Complete the countingValleys function in the editor below.
//countingValleys has the following parameter(s):
//int steps: the number of steps on the hike
//string path: a string describing the path
//Returns
//int: the number of valleys traversed
public class CountingValleys
{
    private static readonly string path = "DDUUDDUDUUUD";
    public static void Run()
    {
        Console.WriteLine("Path : "+ path);
        int level = 0, previous = 0, valleys = 0;
        for (int i = 0; i < path.Length; i++)
        {
            if (path[i] == 'U')
            {
                level++;
            }
            else
            {
                level--;
            }
            if(previous <level && level == 0)
            {
                valleys++;
            }
            previous = level;
        }
    }
}

//Complete the function pangrams in the editor below.It should return the string pangram if the input string is a pangram.Otherwise, it should return not pangram.
//pangrams has the following parameter(s):
//string s: a string to test
//Returns
//string: either pangram or not pangram
public class Pangrams
{
    private static readonly string s = "We promptly judged antique ivory buckles for the next prize";
    public static void Run()
    {
        Console.WriteLine("input string is :");
        Console.WriteLine(s);
        var alphabets = "abcdefghijklmnopqrstuvwxyz";
        var allAlphabets = new int[26];
        if (s.Length < 26)
        {
            Console.WriteLine("not pangram");
        }
        for (int i = 0; i < alphabets.Length; i++)
        {
            if (s.ToLower().Contains(alphabets[i]))
            {
                if (allAlphabets[i] == 0)
                {
                    allAlphabets[i]++;
                }
            }
        }

        var sum = allAlphabets.Sum();
        if (sum == 26)
        {
            Console.WriteLine("pangram");
        }
        else
        {
            Console.WriteLine("not pangram");
        }
    }
}

//A space explorer's ship crashed on Mars! They send a series of SOS messages to Earth for help.
//Letters in some of the SOS messages are altered by cosmic radiation during transmission.Given the signal received by Earth as a string, , determine how many letters of the SOS message have been changed by radiation.
//Example
//s="SOSTOT"
//The original message was SOSSOS. Two of the message's characters were changed in transit.
//Function Description
//Complete the marsExploration function in the editor below.
//marsExploration has the following parameter(s):
//string s: the string as received on Earth
//Returns
//int: the number of letters changed during transmission
public class MarsExploration
{
    private static readonly string s = "SOSSPSSQSSOR";
    public static void Run()
    {
        Console.WriteLine("Input string : "+ s);
        var partsDiff = BreakString(s, 3).Select(s=> WordsDeviation("SOS", s));
        Console.WriteLine("Deviation :" + partsDiff.Sum());
    }

    private static int WordsDeviation(string refWord, string s)
    {
        int changed = 0;
        for (int i = 0; i < refWord.Length; i++)
        {
            if (refWord[i] != s[i])
            {
                changed++;
            };
        }
        return changed;
    }

    private static IEnumerable<string> BreakString(string s, int partSize)
    {
        return Enumerable.Range(0, s.Length / partSize).Select(i => s.Substring(i * partSize, partSize));
    }
}

public class FilipMatrix
{
    private static List<List<int>> matrix = new List<List<int>>()
    {
        new List<int> { 112,42,83,119 },
        new List<int> { 56,125,56,49 },
        new List<int> { 15,78,101,43 },
        new List<int> { 62,98, 114,108 }
    };

    public static void Run()
    {
        Console.WriteLine("Input Matrix:");
        foreach(var m in matrix)
        {
            Console.WriteLine(string.Join(",", m.ToArray()));
            FlipMatrix();
        }
    }

    private static void FlipMatrix()
    {
        var n = matrix.Count / 2;
        var total = 0;
        for(int row = 0; row < n; row++)
        {
            for(int col = 0; col < n; col++)
            {
                var leftTop = matrix[row][col];
                var rightTop = matrix[row][2*n - col -1];
                var leftBottom = matrix[2 * n - row - 1][col];
                var rightBottom = matrix[2*n - row - 1][2*n - col - 1];
                var allElements = new int[] { leftTop, rightTop, leftBottom, rightBottom };
                total += allElements.Max();
            }
        }
        Console.WriteLine("Total =" + total);
    }
}