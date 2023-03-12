namespace DesignPatters.Factory.Simple;
public class Tiger : IAnimal
{
    public void Action()
    {
        Console.WriteLine("Tiger prefer hunting..");
    }

    public void Speak()
    {
        Console.WriteLine("Tiger says: Roar..");
    }
}
