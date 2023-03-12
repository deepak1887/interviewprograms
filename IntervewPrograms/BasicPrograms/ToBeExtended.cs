namespace BasicPrograms;
public class ToBeExtended
{
    private string ClassName { get; set; } = string.Empty;

    public void SetClassName()
    {
        ClassName = typeof(ToBeExtended).Name;
    }
    public string GetClassName()
    {
        return ClassName;
    }
}

public static class ToBeExtendedExtension
{
    public static string SetClassNameNew(this ToBeExtended name, string str)
    {
        return str;
    }
}
