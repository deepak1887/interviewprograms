namespace BasicPrograms.Oops.Polymorphism;
public class Base
{
    public void Name()
    {
        Console.WriteLine(typeof(Base).Name);
    }

    public virtual void VirtualName()
    {
        Console.WriteLine(typeof (Base).FullName);
    }
}
