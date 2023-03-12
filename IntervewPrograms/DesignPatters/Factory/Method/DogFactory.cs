using DesignPatters.Factory.Simple;

namespace DesignPatters.Factory.Method;
public class DogFactory : IAnimalFactory
{
    public IAnimal CreateAnimal()
    {
        return new Dog();
    }
}
