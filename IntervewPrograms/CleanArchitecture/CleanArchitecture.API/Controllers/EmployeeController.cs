using CleanArchitecture.Core.Entities;
using CleanArchitecture.Core.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace CleanArchitecture.API.Controllers;
[ApiController]
[Route("api/v1/[controller]")]
public class EmployeeController : ControllerBase
{
    private readonly IEmployeesRepository employeesRepository;
    public EmployeeController(IEmployeesRepository employeesRepository)
    {
        this.employeesRepository = employeesRepository;
    }
    [Route("[action]")]
    [HttpGet]

    [ProducesResponseType(typeof(IEnumerable<Employee>), (int)HttpStatusCode.OK)]
    public async Task<IActionResult> GetAllEmployees()
    {
        var employees = await employeesRepository.GetAllAsync();
        return Ok(employees);
    }
}
