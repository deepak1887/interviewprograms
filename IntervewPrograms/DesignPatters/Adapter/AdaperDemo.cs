namespace DesignPatters.Adapter;
public class AdaperDemo
{
    public static void Start()
    {
        Console.WriteLine("Adapter patter demo");
        Console.WriteLine("\ncreate rectangle");
        var rectangle = new Rectangle(10, 20);
        rectangle.AboutRectangle();
        Console.WriteLine($"Area of rectangle: {rectangle.CalculateAreaOfRectangle()}");
        Console.WriteLine("\ncreate triangle");
        var triangle = new Triangle(30, 10);
        triangle.AboutTriangle();
        Console.WriteLine($"Area of triangle: {triangle.CalculateAreaOfTriangle()}");
        Console.WriteLine("\nSet up triangle adapter");
        IRectangle adapter = new TriangleAdapter(triangle);
        adapter.AboutRectangle();
        Console.WriteLine($"Area of triangle adapter: {adapter.CalculateAreaOfRectangle()}");
    }
}
