using DesignPatters.Factory.Abstract;
using DesignPatters.Factory.Method;
using DesignPatters.Factory.Simple;

namespace DesignPatters.Factory;
public class FactoryDemo
{
    public static void Start()
    {
        Console.WriteLine("simple factory pattern");
        Console.WriteLine("creating a instance of dog");

        var factoryDog = new SimpleFactory().CreateAnimal(0);
        factoryDog.Speak();
        factoryDog.Action();

        Console.WriteLine("\n");
        Console.WriteLine("factory method pattern");
        Console.WriteLine("creating a instance of dog");
        IAnimal factoryMethodDog = new DogFactory().CreateAnimal();
        factoryMethodDog.Speak();
        factoryMethodDog.Action();

        Console.WriteLine("\n");
        Console.WriteLine("Abstract factory method");
        Console.WriteLine("creating a instance of dog");
        var petDog = new PetAnimalFactory().GetDog();
        petDog.Speak();
        petDog.Action();

        var wildDog = new WildAnimalFactory().GetDog();
        wildDog.Speak();
        wildDog.Action();
    }
}