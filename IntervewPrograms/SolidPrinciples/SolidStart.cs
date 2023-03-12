namespace SolidPrinciples;
public class SolidStart
{
    public static void Run()
    {
        Console.WriteLine("please select section no");
        Console.WriteLine("1. SRP - Single Responsibility Principle");
        Console.WriteLine("2. Open and close");
        Console.WriteLine("3. Liskoves Substitution");
        Console.WriteLine("4. Dependency Inversion");
        var section = Convert.ToInt32(Console.ReadLine());
        switch (section)
        {
            case 1:
                SingleResponsibility.Start();
                break;
            case 2:
                OpenAndClose.Start();
                break;
            default:
                break;
        }
    }
}
