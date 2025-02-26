
namespace SimpleWebApi.Services;

public class WriteToPDF : IWriter
{
    public async Task WriteAsync()
    {

        System.Diagnostics.Debug.Print("Write PDF");
    }
}
