namespace DesignPatters.Strategy;
public class FirstChoice : IChoice
{
    public void MyChoice()
    {
        Console.WriteLine("First choise output");
    }
}