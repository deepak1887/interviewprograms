namespace Problems;
public class StringOperation
{
    public static void RevString()
    {
        Console.WriteLine("Enter string to reverse");
        string input = Console.ReadLine() ?? string.Empty;
        string[] inputArray = input.Split(' ');
        string result = string.Join(" ", inputArray.Select(x => new string(x.Reverse().ToArray())));
        Console.WriteLine(result);
        Console.ReadKey();
    }
    public static void CheckPlindrome()
    {
        Console.WriteLine("Enter string to check palindrom");
        string input = Console.ReadLine() ?? string.Empty;
        if (input == string.Join(" ", input.Split(' ').Select(x => new string(x.Reverse().ToArray()))))
        {
            Console.WriteLine("string is palindrome");
        }
        else
        {
            Console.WriteLine("string is not palindrome");
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
}
