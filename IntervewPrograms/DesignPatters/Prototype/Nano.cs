namespace DesignPatters.Prototype;
public class Nano : BasicCar
{
    public Nano(string modelName)
    {
        this.modelName = modelName;
    }
    public override BasicCar Clone()
    {
        return (Nano)MemberwiseClone();
    }
}