namespace BasicPrograms.HakerRank;

public class BreakingTheRecords
{

    private static List<int> scores = new() { 10, 5, 20, 20, 4, 5, 2, 25, 1 };

    public static List<int> Run()
    {
        int highScore = 0, lowScore = 0;
        int min = 0, max = 0;
        for (int i = 0; i < scores.Count; i++)
        {
            if (scores[i] > highScore)
            {
                highScore = scores[i];
                max++;
            }
            if (scores[i] < lowScore)
            {
                lowScore = scores[i];
                min++;
            }
        }
        return new List<int>() { max, min };
    }
}

public class CamelCase
{
    private static string[] args = new string[] { "S;M;plasticCup()", "C;V;mobile phone", "C;C;coffee machine", "S;C;LargeSoftwareBook", "C;M;white sheet of paper", "S;V;pictureFrame" };

    public static void Run()
    {

        foreach (string arg in args)
        {

            //get input string
            int firstStart = arg.IndexOf(';') + 1;
            string second = arg.Substring(firstStart, 1);
            int start = arg.LastIndexOf(';') + 1;
            var first = arg[..start];
            var inputstr = arg.Substring(start);
            switch (first[0])
            {
                case 'S':
                    inputstr = string.Join(" ", Split(inputstr));
                    break;
                case 'C':
                    inputstr = string.Join("", Combine(inputstr));
                    if (second == "M")
                    {
                        inputstr += "()";
                    }
                    if (second == "C")
                    {
                        inputstr = FirstUpperChar(inputstr);
                    }
                    break;
                default:
                    break;
            }


            Console.WriteLine($"{inputstr.TrimStart()}");
        }
    }

    //Split --method class varibale need to split word, -staring with lowercase
    //combine word start with lowercase combined with camel case, method end with () -- first small baaki caps
    //S;V;iPad
    //C; M;mouse pad
    //C;C;code swarm
    //S;C;OrangeHighlighter
    //split
    //split from first capital Letter
    private static List<string> Split(string str) // Addspce to fist caps
    {
        var strList = str.ToList();
        var temp = new List<char>();
        for (int i = 0; i < strList.Count; i++)
        {
            if (!char.IsUpper(str[i]))
            {
                temp.Add(str[i]);
            }
            else
            {
                temp.Add(' ');
                temp.Add(str[i]);
            }
        }
        var result = new string(temp.ToArray());
        return result.Split(" ").Select(x => FirstLowerChar(x).Replace("(", "").Replace(")", "")).ToList();
    }

    //combine
    private static List<string> Combine(string str)
    {
        var result = str.Split(' ');
        if (result.Length > 1)
        {
            for (int i = 1; i < result.Length; i++)
            {
                result[i] = FirstUpperChar(result[i]);
            }
        }
        return result.ToList();
    }


    private static string FirstUpperChar(string str)
    {
        if (!string.IsNullOrWhiteSpace(str) && str.Length > 0)
        {
            str = char.ToUpper(str[0]) + str[1..];
        }
        return str;
    }
    private static string FirstLowerChar(string str)
    {
        if (!string.IsNullOrWhiteSpace(str) && str.Length > 0)
        {
            str = char.ToLower(str[0]) + str[1..];
        }
        return str;
    }

}