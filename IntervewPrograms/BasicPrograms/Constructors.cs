namespace BasicPrograms;
public class A
{
    public A()
    {
        Console.WriteLine("A Default Constructor");
    }
    public A(string s) : this()
    {
        Console.WriteLine("A Parameterized Constructor");
    }
    static A()
    {
        Console.WriteLine("A Static Constructor");
    }
    public void PrintA()
    {
        Console.WriteLine("A Print Method");
    }
    public virtual void Print()
    {
        Console.WriteLine("A virtual method");
    }
    public void PrintCommon()
    {
        Console.WriteLine("A Common Print Method");
    }
}
public class B : A
{
    public B()
    {
        Console.WriteLine("B Default Constructor");
    }
    public B(string s) : base(s)
    {
        Console.WriteLine("B Parameterized Constructor");
    }
    static B()
    {
        Console.WriteLine("B Static Constructor");
    }
    public void PrintB()
    {
        Console.WriteLine("B Print Method");
    }
    public override void Print()
    {
        Console.WriteLine("B virtual method");
    }
    public new void PrintCommon()
    {
        Console.WriteLine("B Common Print Method");
    }
}

public class C : B
{
    public C()
    {
        Console.WriteLine("C Default Constructor");
    }
    public C(string s) : base(s)
    {
        Console.WriteLine("C Parameterized Constructor");
    }
    static C()
    {
        Console.WriteLine("C Static Constructor");
    }

    public new void Print()
    {
        Console.WriteLine("C virtual method");
    }



}

public class StaticConstructorOnly
{
    static StaticConstructorOnly()
    {

    }
}
public class DefaultConstructorOnly
{
    public DefaultConstructorOnly()
    {

    }
}
public class ParameterizedConstructorOnly
{
    public ParameterizedConstructorOnly(int A)
    {

    }
}
public class CopyConstructorOnly
{
    public CopyConstructorOnly(CopyConstructorOnly cpy)
    {

    }
}

public abstract class AbstractClass
{
    public AbstractClass()
    {
        Console.WriteLine("Abstract class constructor");
    }
}
