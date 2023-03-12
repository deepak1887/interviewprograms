namespace DesignPatters.Prototype;
public abstract class BasicCar
{
    public string? modelName { get; set; }
    public int price { get; set; }
    public static int SetPrice()
    {
        var r = new Random();
        //int p = r.Next(200000, 500000);
        //int price = r.Next(200000, 500000);
        return r.Next(200000, 500000);
    }
    public abstract BasicCar Clone();
}
