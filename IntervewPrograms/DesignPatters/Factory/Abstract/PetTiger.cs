namespace DesignPatters.Factory.Abstract;
public class PetTiger : ITiger
{
    public void Action()
    {
        Console.WriteLine("Pet Tigers play in an animal circus.");
    }

    public void Speak()
    {
        Console.WriteLine("Pet Tiger says: Halum.");
    }
}
