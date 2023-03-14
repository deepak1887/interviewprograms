namespace BasicPrograms.Interfaces;
public class InterfaceDemo
{
    public static void Run()
    {
        Console.WriteLine("we have a base interface with method print");
        Console.WriteLine("we have a similar interface with method print");
        Console.WriteLine("and now we have a derived interface which inherits both of them");
        Console.WriteLine("so we have to implement both of them explicitly");
        Console.WriteLine("So creating a class impl2 derived which implements over derived interface");
        Console.WriteLine("To use the interface implementation we have to use it in below patter");
        IBaseInterface impl = new Impl2();
        Console.WriteLine("IBaseInterface impl = new Impl2()");
        impl.Print();
        IOther impl2 = new Impl2();
        Console.WriteLine(" IOther impl2 = new Impl2()");
        impl2.Print();
    }
}