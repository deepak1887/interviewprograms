namespace BasicPrograms;
//Defenation on MSDN
//Delegates allow polymorphism by encapsulating a method that matches the delegate signature.
//The method encapsulated by the delegate is decided at runtime.
//An object can publish a series of events to which other classes can subscribe.
//The publishing class defines a delegate and an event based on that delegate.
public class Delegates
{
    //steps to create delegate
    //1. Define a Delegate
    //2. Define a event based on Delegate
    //3. Raise the event.


    public delegate void PrintDoneEventHandler(object source, EventArgs args);
    public event PrintDoneEventHandler? PrintDone;
    public void PrintAndWait(string input)
    {
        Console.WriteLine("Event Started and will wait for 5 Sec and input string is {0}", input);
        Thread.Sleep(3000);
        Console.WriteLine("Wait Over");
        OnPrintDone();
    }

    protected virtual void OnPrintDone()
    {
        if (PrintDone != null)
        {
            Console.WriteLine("Event Raised");
            PrintDone(this, EventArgs.Empty);
        }

    }
}
