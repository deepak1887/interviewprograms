namespace DesignPatters.Adapter;
public class TriangleAdapter : IRectangle
{
    readonly Triangle triangle;
    public TriangleAdapter(Triangle t) => triangle = t;
    public void AboutRectangle()
    {
        triangle.AboutTriangle();
    }
    public double CalculateAreaOfRectangle()
    {
        return triangle.CalculateAreaOfTriangle();
    }
}
