namespace DesignPatters.Strategy;
public class SecondChoice: IChoice
{
    public void MyChoice()
    {
        Console.WriteLine("Second choise output");
    }
}