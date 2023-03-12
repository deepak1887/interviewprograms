namespace BasicPrograms;
public class Overloading
{
    public static void Sum(int a, int b)
    {
        Console.WriteLine(a + b);
    }

    public static void Sum(int a, int b, int c)
    {
        Console.WriteLine(a + b + c);
    }

    public static void Sum(string a, string b)
    {
        string c = a + " " + b;
        Console.WriteLine(c);
    }

}
