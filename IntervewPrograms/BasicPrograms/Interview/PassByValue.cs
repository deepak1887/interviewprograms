namespace BasicPrograms.Interview;
public class PassByValue
{
    public string? Name { get; set; }
    public int Value { get; set; }
    public PassByStruct Struct { get; set; }
    public PassByValue2 PassByValue2 { get; set; }


}
public struct PassByStruct
{
    public string Name { get; set; }
    public int Value { get; set; }

}
public struct PassByValue2
{
    public string Name { get; set; }
    public int Value { get; set; }

}
