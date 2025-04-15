using System.Text;

namespace Problems;
public class StringOperation
{
    private static List<string> StringParts(string s, int partSize)
    {
        return Enumerable.Range(0, partSize).Select(i => s.Substring(i*partSize, partSize)).ToList();
    }
    private static string ReverseString(string input, int start = 0, int end = 0)
    {
        char[] characters = input.ToCharArray();
        int length = end == 0 ? characters.Length : end;
        for (int i = start; i < length / 2; i++)
        {
            //char temp = characters[i];
            //characters[i] = characters[length - 1 - i];
            //characters[length - 1 - i] = temp;

            (characters[length - 1 - i], characters[i]) = (characters[i], characters[length - 1 - i]);
        }
        return new string(characters);
    }
    private static string ReverseString(char[] characters, int start = 0, int end = 0)
    {
        int length = end == 0 ? characters.Length : end;
        for (int i = start; i < length / 2; i++)
        {
            (characters[length - 1 - i], characters[i]) = (characters[i], characters[length - 1 - i]);
        }
        return new string(characters);
    }

    public static void ReverseStringWithSpaces()
    {
        Console.WriteLine("Enter string to reverse");
        string input = Console.ReadLine() ?? string.Empty;
        string[] inputArray = input.Split(' ');
        string result = string.Join(" ", inputArray.Select(x => ReverseString(x)));
        Console.WriteLine(result);
        Console.ReadKey();
    }

    public static void RevStringWithoutInbuilt()
    {
        Console.WriteLine("Enter string to reverse");
        string input = Console.ReadLine() ?? string.Empty;
        Console.WriteLine(ReverseString(input));
        Console.ReadKey();
    }

    

    public static void CheckPlindrome()
    {
        Console.WriteLine("Enter string to check palindrom");
        string input = Console.ReadLine() ?? string.Empty;
        if (input == string.Join(" ", input.Split(' ').Select(x => ReverseString(x))))
        {
            Console.WriteLine($"{input} is palindrome");
        }
        else
        {
            Console.WriteLine($"{input} is not palindrome");
        }
        Console.ReadKey();
    }

    public static List<string> SplitString(char splitFrom, string input)
    {
        var listString = new List<string>();
        string temp = "";
        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] != splitFrom)
            {
                temp += input[i];
            }
            else
            {
                listString.Add(temp);
                temp = "";
            }
            if (i == input.Length - 1)
            {
                listString.Add(temp);
                temp = "";
            }
        }
        return listString;
    }

    public static void ReverseStringWithSpecialChar()
    {
        Console.WriteLine("Enter string to reverse");
        string input = Console.ReadLine() ?? string.Empty;
        Reverse(input.ToCharArray());

    }

    public static void Reverse(char[] s)
    {
        // creating character array of size
        // equal to length of string
        char[] temp = new char[s.Length];
        int x = 0;
        for (int i = 0; i < s.Length; i++)
        {
            if ((s[i] >= 'a' && s[i] <= 'z')
                || (s[i] >= 'A' && s[i] <= 'Z'))
            {
                // storing elements in array
                temp[x] = s[i];
                x++;
            }
        }

        // reversing the character array
        //Rev(temp, 0, x);
        ReverseString(temp, 0, x);
        x = 0;
        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] >= 'a' && s[i] <= 'z'
                || s[i] >= 'A' && s[i] <= 'Z')
            {
                // updating the origional string
                s[i] = temp[x];
                x++;
            }
        }

        string revStr = new string(s);
        Console.WriteLine("reversed string is: " + revStr);
    }

    public static void IsAnagramString(string a, string b)
    {
        if (a.Length != b.Length) return;
        int length = a.Length;
        bool isAnagram = true;
        var hashMap = new HashSet<char>();
        for (int i = 0; i < length; i++)
        {
            hashMap.Add(a[i]);
        }

        for (int i = 0; i <length; i++)
        {
            if (!hashMap.Contains(b[i]))
            {
                isAnagram = false;
                break;
            }
        }
        var sb = new StringBuilder();
        sb.Append($"{a}, {b} are ");
        if (isAnagram)
        {
            sb.Append("Anagrams");
        }
        else
        {
            sb.Append(" not Anagrams");
        }
        Console.WriteLine(sb.ToString());
        Console.ReadKey();
    }

    public static void GetCharacterCount(string input)
    {
        char[] chars = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
        int[] counts = new int[26];
        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] == ' ')
                continue;
            counts[Array.IndexOf(chars, input[i])]++;
        }
        for (int i = 0; i < counts.Length; i++)
        {
            if (counts[i] > 0)
                Console.WriteLine($"{chars[i]} - {counts[i]}");
        }
    }
}

public class StringOperationDemo
{
    public static void Run()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Welecome to string problems.\nSelect options from below");
            Console.WriteLine("1. Reverse of string");
            Console.WriteLine("2. Check palindrome");
            Console.WriteLine("3. Reverse string with special char maintain special char position");
            Console.WriteLine("4. Check Anagram");
            //Console.WriteLine("3. Print Right Pyramid");
            //Console.WriteLine("4. Print Inverted Pyramid");
            Console.WriteLine("5. Print word count");
            Console.WriteLine("10. Exit");
            int i = Convert.ToInt32(Console.ReadLine());
            switch (i)
            {
                case 1:
                    StringOperation.RevStringWithoutInbuilt();
                    break;
                case 2:
                    StringOperation.CheckPlindrome();
                    break;
                case 3:
                    StringOperation.ReverseStringWithSpecialChar();
                    break;
                case 4:
                    StringOperation.IsAnagramString("cat", "tal");
                    break;
                case 5:
                    StringOperation.GetCharacterCount("hello world");
                    break;
                case 10:
                default:
                    break;
            }
            if (i == 10)
            {
                break;
            }
        }
    }
}
