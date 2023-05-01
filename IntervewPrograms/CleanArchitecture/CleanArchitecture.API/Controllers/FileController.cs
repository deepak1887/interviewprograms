using Microsoft.AspNetCore.Mvc;

namespace CleanArchitecture.API.Controllers;

[ApiController]
public class FileController : ControllerBase
{
    //private const MaxFileSize = 10L * 1024L * 1024L * 1024L; // 10GB, adjust to your need
    [DisableRequestSizeLimit]
    [RequestFormLimits(ValueLengthLimit = int.MaxValue, MultipartBodyLengthLimit = int.MaxValue)]
    public async Task<IActionResult> Upload(IFormFile file)
    {
        if (file == null)
            return Ok(new { success = false, message = "You have to attach a file" });

        var fileName = file.FileName;
        // var extension = Path.GetExtension(fileName);

        // Add validations here...

        var localPath = $"{Path.Combine(System.AppContext.BaseDirectory, "myCustomDir")}\\{fileName}";

        // Create dir if not exists
        Directory.CreateDirectory(Path.Combine(System.AppContext.BaseDirectory, "myCustomDir"));

        using (var stream = new FileStream(localPath, FileMode.Create))
        {
            await file.CopyToAsync(stream);
        }

        // db.SomeContext.Add(someData);
        // await db.SaveChangesAsync();

        return Ok(new { success = true, message = "All set", fileName });
    }
}
