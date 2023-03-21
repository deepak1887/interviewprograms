using CleanArchitecture.Core.Interfaces;
using CleanArchitecture.Infrastructure.Data;
using CleanArchitecture.Infrastructure.Reposities;
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
