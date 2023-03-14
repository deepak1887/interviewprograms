namespace BasicPrograms.Interfaces;
public class Impl2 : IBaseInterface, IOther
{

    //Explicit interface implementation does not support public as access modifier and in order to
    //use its functionality need to be casted to use type
    void IOther.Print()
    {
        Console.WriteLine("implementation of " + typeof(IOther).Name +" with "+  typeof(Impl2).Name);
    }

    void IBaseInterface.Print()
    {
        Console.WriteLine("implementation of " + typeof(IBaseInterface).Name + " with " + typeof(Impl2).Name);
    }
}
