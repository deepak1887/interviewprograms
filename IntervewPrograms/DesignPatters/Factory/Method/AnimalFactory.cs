using DesignPatters.Factory.Simple;

namespace DesignPatters.Factory.Method;

public interface IAnimalFactory
{
    IAnimal CreateAnimal();
}

public abstract class AnimalFactory : IAnimalFactory
{
    //public IAnimal MakeAnimal()
    //{
    //    IAnimal animal = CreateAnimal();
    //    animal.speak();
    //    animal.Action();
    //    return animal;
    //}

    public abstract IAnimal CreateAnimal();
}
