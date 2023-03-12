using DesignPatters.Factory.Abstract;

namespace DesignPatters.Factory.Abstrac;
public class WildTiger : ITiger
{
    public void Action()
    {
        Console.WriteLine("Wild Tigers prefer hunting in jungles.");
    }

    public void Speak()
    {
        Console.WriteLine("Wild Tiger says: Halum.");
    }
}
