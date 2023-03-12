namespace BasicPrograms;
public class AsyncAwait
{
    private int ReadFile()
    {
        using var reader = new StreamReader("C:\\Users\\Deepak\\Desktop\\Deepak_Formatted.docx");
        string content = reader.ReadToEnd();
        Thread.Sleep(5000);
        return content.Length;
    }

    public async void DocumentLength()
    {
        Console.WriteLine("File Read Started");
        Task<int> task = new Task<int>(ReadFile);
        task.Start();
        Console.WriteLine("Processing......");
        int count = await task.ConfigureAwait(true);
        Console.WriteLine("abcd");
        Console.WriteLine("File Length is = {0}", count);
    }
}
