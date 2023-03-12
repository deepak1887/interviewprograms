namespace BasicPrograms.Interfaces;
internal class Impl2 : IBaseInterface, IOther
{

    //Explicit interface implementation does not support public as access modifier and in order to
    //use its functionality need to be casted to use type
    void IOther.Print()
    {
        Console.WriteLine(typeof(IOther).Name +  typeof(Impl2).Name);
    }

    void IBaseInterface.Print()
    {
        Console.WriteLine(typeof(IBaseInterface).Name + typeof(Impl2).Name);
    }
}
