namespace DesignPatters.Factory.Simple;
public class SimpleFactory: SimpleFactoryAbstract
{
    public override IAnimal CreateAnimal(int input)
    {
        IAnimal intendedAnimal = null;
        switch (input)
        {
            case 0:
                intendedAnimal = new Dog();
                break;
            case 1:
                intendedAnimal = new Tiger();
                break;
            default:
                //WriteAsync("Choice must be either 0 or 1");                    
                //We'll throw a runtime exception for any other choices.
                throw new ApplicationException(string.Format(" Unknown Animal cannot be instantiated"));
        }
        return intendedAnimal;
    }
}

public abstract class SimpleFactoryAbstract {

    public abstract IAnimal CreateAnimal(int selectedAnimal);
}
