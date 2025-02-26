
namespace SimpleWebApi.Services;

public class WriteToWord : IWriter
{
    public async Task WriteAsync()
    {
        System.Diagnostics.Debug.Print("Write Word");
    }
}
