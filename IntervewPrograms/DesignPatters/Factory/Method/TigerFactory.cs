using DesignPatters.Factory.Simple;

namespace DesignPatters.Factory.Method;
public class TigerFactory : IAnimalFactory
{
    public IAnimal CreateAnimal()
    {
        return new Tiger();
    }
}
