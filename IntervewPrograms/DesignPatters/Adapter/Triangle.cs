namespace DesignPatters.Adapter;
public class Triangle : ITriangle
{
    public double baseLength;//base
    public double height;//height
    public Triangle(double b, double h)
    {
        baseLength = b;
        height = h;
    }
    public double CalculateAreaOfTriangle()
    {
        return 0.5 * baseLength * height;
    }
    public void AboutTriangle()
    {
        Console.WriteLine("Actually, I am a Triangle");
    }
}
