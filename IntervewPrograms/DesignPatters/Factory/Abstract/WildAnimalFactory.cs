using DesignPatters.Factory.Abstrac;

namespace DesignPatters.Factory.Abstract;
public class WildAnimalFactory : IAnimalFactory
{
    public IDog GetDog()
    {
        return new WildDog();
    }

    public ITiger GetTiger()
    {
        return new WildTiger();
    }
}
