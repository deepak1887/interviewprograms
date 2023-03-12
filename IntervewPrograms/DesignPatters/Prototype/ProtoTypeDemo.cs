namespace DesignPatters.Prototype;
public class ProtoTypeDemo
{
    public static void Start()
    {
        Console.WriteLine("Demo for protype pattern");
        Console.WriteLine("Create original cars");
        BasicCar nano = new Nano("Red Nano") { price = 100000 };
        Console.WriteLine("created Red Nano");
        BasicCar ford = new Ford("Blue Ford") { price = 500000 };
        Console.WriteLine("created Blue Ford");

        BasicCar nano_clone;
        nano_clone = nano.Clone();
        nano_clone.price = nano.price + BasicCar.SetPrice();
        nano_clone.modelName = nano.modelName + " Shining";
        Console.WriteLine($"Original: care name: {nano.modelName} price: {nano.price}");
        Console.WriteLine($"Clone: Color: {nano_clone.modelName} care name: {nano_clone.modelName} price: {nano_clone.price}");

        BasicCar ford_clone;
        ford_clone = ford.Clone();
        ford_clone.price = ford.price + BasicCar.SetPrice();
        ford_clone.modelName = ford.modelName + " Shining";
        Console.WriteLine($"Original: care name: {ford.modelName} price: {ford.price}");
        Console.WriteLine($"Clone: clone:{ford_clone.modelName} care name: {ford_clone.modelName} price: {ford_clone.price}");
    }
}
