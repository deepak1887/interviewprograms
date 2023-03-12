namespace DesignPatters.Prototype;
public class Ford : BasicCar
{
    public Ford(string modelName)
    {
        this.modelName = modelName;
    }
    public override BasicCar Clone()
    {
        return (Ford)MemberwiseClone();
    }
}
