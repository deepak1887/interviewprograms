namespace BasicPrograms;
public class AnanomusFuntions
{
    public delegate void Print(int value);

    //created and consumed on the same page
    Print prt = delegate (int val)
    {
        Console.WriteLine("Print value id {0}, from ananomus function");
    };
}
