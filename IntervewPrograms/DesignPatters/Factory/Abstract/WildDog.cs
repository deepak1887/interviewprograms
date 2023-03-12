namespace DesignPatters.Factory.Abstract;
public class WildDog : IDog
{
    public void Action()
    {
        Console.WriteLine("Wild Dogs prefer to roam freely in jungles.");
    }

    public void Speak()
    {
        Console.WriteLine("Wild Dog says: Bow-Wow.");
    }
}