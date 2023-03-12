namespace DesignPatters.Factory.Abstract;
public class PetDog : IDog
{
    public void Action()
    {
        Console.WriteLine("Pet Dogs prefer to stay at home");
    }

    public void Speak()
    {
        Console.WriteLine("Pet dog says : Bow wow");
    }
}
