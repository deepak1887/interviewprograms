using CleanArchitecture.Core.Entities;
using CleanArchitecture.Core.Interfaces;
using CleanArchitecture.Infrastructure.Data;

namespace CleanArchitecture.Infrastructure.Reposities;
public class EmployeeRepository : RepositoryBase<Employee>, IEmployeesRepository
{
    public EmployeeRepository(AppDbContext dbContext) : base(dbContext)
    {
    }
}
