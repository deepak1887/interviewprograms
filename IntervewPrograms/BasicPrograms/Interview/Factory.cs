using BasicPrograms.Interview.FactoryChild;

namespace BasicPrograms.Interview;
public class Factory
{
    public static IFactoryManager GetObject(string type)
    {
        return type switch
        {
            "ChildA" => new ChildA(),
            "ChildB" => new ChildB(),
            _ => new ChildB(),
        };
    }
}
