using CleanArchitecture.API.Filters;
using CleanArchitecture.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddInfrastructure(builder.Configuration);

//Add Filters
builder.Services.AddControllers(config =>
{
    config.Filters.Add(new AuthFilterAttribute());
    config.Filters.Add(new ActionFilterAttribute());
    config.Filters.Add(new ResultFilterAtribute());
    config.Filters.Add(new ExceptionFilterAttribute());
});

//using(var scope = builder.Services)


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    //app.UseSwaggerUI();
    app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Clean.API v1"));
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
