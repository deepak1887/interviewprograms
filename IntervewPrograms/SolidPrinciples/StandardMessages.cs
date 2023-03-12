namespace SolidPrinciples;
public class StandardMessages
{
    public static void WelcomeMessage()
    {
        Console.WriteLine("Welcome to solid principles application !!");
    }

    public static void EndApplication()
    {
        Console.ReadLine();
    }

    public static void DisplayValidationError(string fieldName)
    {
        Console.WriteLine($"{fieldName} is required");
    }
}
