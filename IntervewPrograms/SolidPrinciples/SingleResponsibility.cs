namespace SolidPrinciples;

//everycalss should have a single responsibility
public class SingleResponsibility
{
    public static void Start()
    {
        StandardMessages.WelcomeMessage();

        var person = PersonDataCapture.Capture();
        var isValid = PersonValidator.Validate(person);

        if (!isValid)
        {
            StandardMessages.EndApplication();
        }

        AccountGenerator.CreatAccount(person);
        StandardMessages.EndApplication();
    }

}
public class Person
{
    public string? FirstName { get; set; } = string.Empty;
    public string? LastName { get; set; } = string.Empty;
}

public class PersonDataCapture
{
    public static Person Capture()
    {
        var person = new Person();
        Console.Write("what is you first name: ");
        person.FirstName = Console.ReadLine();

        Console.Write("what is you last name: ");
        person.LastName = Console.ReadLine();
        return person;
    }
}
public class PersonValidator
{
    public static bool Validate(Person person)
    {
        if (string.IsNullOrEmpty(person.FirstName))
        {
            StandardMessages.DisplayValidationError("first name");
            return false;
        }

        if (string.IsNullOrEmpty(person.LastName))
        {
            StandardMessages.DisplayValidationError("last name");
            return false;
        }
        return true;
    }
}

public class AccountGenerator
{
    public static void CreatAccount(Person person)
    {
        Console.WriteLine($"your username is {person.FirstName?[..1]}{person.LastName}");
    }
}