using CleanArchitecture.Core.Interfaces;
using CleanArchitecture.Infrastructure.Data;
using CleanArchitecture.Infrastructure.Reposities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CleanArchitecture.Infrastructure;
public static class Infrastructure
{
    public static void AddInfrastructure(this IServiceCollection services, IConfiguration configurations)
    {
        services.AddDbContext<AppDbContext>(options => options.UseSqlServer(configurations.GetConnectionString("SqlConnection")));
        services.AddScoped(typeof(IRepositoryBase<>), typeof(RepositoryBase<>));
        services.AddScoped(typeof(IEmployeesRepository), typeof(EmployeeRepository));
        services.AddScoped<IEmployeesRepository, EmployeeRepository>();
    }
}
