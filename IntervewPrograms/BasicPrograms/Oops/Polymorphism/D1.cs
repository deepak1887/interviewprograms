namespace BasicPrograms.Oops.Polymorphism;
internal class D1 : Base
{
    public override void VirtualName()
    {
        Console.WriteLine(typeof(D1).Name);
    }

    public new void Name()
    {
        Console.WriteLine(typeof (D1).Name);
    }
}
