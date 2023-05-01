using CleanArchitecture.Core.Interfaces;
using CleanArchitecture.Infrastructure.Data;
using CleanArchitecture.Infrastructure.Reposities;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.EntityFrameworkCore;

namespace CleanArchitecture.API.Dependencies;

public static class Dependencies
{
    //public static void ConfigureInfrastructure(this IServiceCollection services, IConfiguration configurations)
    //{
    //    services.AddDbContext<AppDbContext>(options => options.UseSqlServer(configurations.GetConnectionString("SqlConnection")));
    //    services.AddScoped(typeof(IRepositoryBase<>), typeof(RepositoryBase<>));
    //    services.AddScoped(typeof(IEmployeesRepository), typeof(EmployeeRepository));
    //    services.AddScoped<IEmployeesRepository, EmployeeRepository>();
    //}
}

public struct Sample: IActionFilter
{
    public Sample(int Id)
    {
        this.Id = Id;
    }
    public int Id { get; set; }
    public Sample2 sample1 { get; set; }

    public string GetName()
    {
        return "";
    }

    public void OnActionExecuted(ActionExecutedContext context)
    {
        throw new NotImplementedException();
    }

    public void OnActionExecuting(ActionExecutingContext context)
    {
        throw new NotImplementedException();
    }
}

public struct Sample2
{

}

public record Record1: IActionFilter
{
    public Record1()
    {
        
    }
    public int Id { get; set; }

    public string GetName()
    {
        return "";
    }

    public void OnActionExecuted(ActionExecutedContext context)
    {
        throw new NotImplementedException();
    }

    public void OnActionExecuting(ActionExecutingContext context)
    {
        throw new NotImplementedException();
    }
}

public record Record2: Record1
{

}