namespace BasicPrograms.Delegates;
public class DelegatesDemo
{
    public static void Run()
    {
        Console.WriteLine("Delegates are pointers to function. Delegates are used for implementing events and call back methods");
        Console.WriteLine("There are three types of system defined delegates");
        Console.WriteLine("1. Func - It takes one or more input parameters and returns one out parameter, Func can contains 0 to 16 input parameters" +
            " \n2. Action - It takes one or more input parameters and returns nothing, Action can contain 1 to 16 input parameters" +
            " \n3. Predicate - It is used to verify certain criteria of method and returns output as Boolean, either True or False");
        Console.WriteLine("User fefined delegate");
        Console.WriteLine("Steps to create");
        Console.WriteLine("Define delegate ex: public delegate void PrintDoneEventHandler(object source, EventArgs args)");
        Console.WriteLine("Define delegate function with exact same signature, then pass it to the function");
        Console.WriteLine("Call the delegate inside function where it is passed as parameter");

    }
}
