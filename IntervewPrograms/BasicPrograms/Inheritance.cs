namespace BasicPrograms;
public class Parent
{
    public virtual void Display()
    {
        Console.WriteLine("Parent display");
    }
}
public class Child : Parent
{
    public override void Display()
    {
        Console.WriteLine("child display");
    }
}
public class SecondChild : Child
{
    public override void Display()
    {
        Console.WriteLine("Second child display");
    }

}
