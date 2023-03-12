namespace DesignPatters.Adapter;
public class Rectangle : IRectangle
{
    private readonly double length;
    private readonly double width;
    public Rectangle(double l, double w)
    {
        length = l;
        width = w;
    }
    public double CalculateAreaOfRectangle()
    {
        return length * width;
    }
    public void AboutRectangle()
    {
        Console.WriteLine("Actually, I am a Rectangle");
    }
}