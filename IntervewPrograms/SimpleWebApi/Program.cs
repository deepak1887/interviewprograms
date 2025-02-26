using Microsoft.Extensions.DependencyInjection;
using SimpleWebApi.Services;
using System.Reflection.Metadata.Ecma335;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
//keyedService
//builder.Services.AddKeyedTransient<IWriter, WriteToPDF>("pdf");
//builder.Services.AddKeyedTransient<IWriter, WriteToWord>("word");

//factory injection
//builder.Services.AddScoped<WriteToPDF>();
//builder.Services.AddScoped<WriteToWord>();
//builder.Services.AddTransient<Func<string, IWriter>>(serviceProvider => Key =>
//{
//    return Key switch
//    {
//        "word" => serviceProvider.GetRequiredService<WriteToWord>(),
//        "pdf" => serviceProvider.GetRequiredService<WriteToPDF>(),
//        _  => throw new ArgumentNullException("Invlid Service Type", nameof(Key)),
//    };
//});


//Servicecollection

builder.Services.AddTransient<IWriter, WriteToPDF>();
builder.Services.AddTransient<IWriter, WriteToWord>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

var summaries = new[]
{
    "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
};

//app.MapGet("/weatherforecast", (Func<string, IWriter> serviceFacory) =>
//{
//    var pdfService = serviceFacory("pdf");
//    var wordService = serviceFacory("word");
//    var forecast = Enumerable.Range(1, 5).Select(index =>
//        new WeatherForecast
//        (
//            DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
//            Random.Shared.Next(-20, 55),
//            summaries[Random.Shared.Next(summaries.Length)]
//        ))
//        .ToArray();
//    return forecast;
//})
//.WithName("GetWeatherForecast")
//.WithOpenApi();

app.MapGet("/weatherforecast", ( IEnumerable<IWriter> writer) =>
{
    var pdfService = writer.First(f => f.GetType() == typeof(WriteToWord));
    pdfService.WriteAsync();
    var forecast = Enumerable.Range(1, 5).Select(index =>
        new WeatherForecast
        (
            DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
            Random.Shared.Next(-20, 55),
            summaries[Random.Shared.Next(summaries.Length)]
        ))
        .ToArray();
    return forecast;
})
.WithName("GetWeatherForecast")
.WithOpenApi();

app.Run();

internal record WeatherForecast(DateOnly Date, int TemperatureC, string? Summary)
{
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
}
