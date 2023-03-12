namespace BasicPrograms.Interfaces;
internal class Impl1 : IBaseInterface
{
    public void Print()
    {
        Console.WriteLine(typeof(Impl1).Name);
    }
}