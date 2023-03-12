namespace SolidPrinciples;
//open for extension close for modification
public class OpenAndClose
{
    public static void Start()
    {
        var applicants = new List<IApplicant>
        {
            new Applicant{ FirstName="deepak", LastName = "sagar"},
            new Executive{ FirstName="vijay", LastName = "sakshi"},
            new Manager{ FirstName="disha", LastName = "sagar"}
        };
        var employees = new List<IEmployee>();
        foreach (var applicant in applicants)
        {
            employees.Add(applicant.AccountProcessor.Create(applicant));
        }

        foreach (var employee in employees)
        {
            Console.WriteLine($"{employee.FirstName} : {employee.LastName} : {employee.Email} : Ismanager:{employee.IsManager} IsExecutive:{employee.IsExecutive}");
        }
        Console.ReadLine();
    }
}

public interface IApplicant
{
    string FirstName { get; set; }
    string LastName { get; set; }
    IAccount AccountProcessor { get; set; }
}

public class Applicant : IApplicant
{
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public IAccount AccountProcessor { get; set; } = new Account();
}
public interface IEmployee
{
    string FirstName { get; set; }
    string LastName { get; set; }
    string Email { get; set; }
    bool IsExecutive { get; set; }
    bool IsManager { get; set; }
}

public class Employee: IEmployee
{
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public bool IsManager { get; set; }
    public bool IsExecutive { get; set; }

}
public class Manager : IApplicant
{
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public IAccount AccountProcessor { get; set; } = new ManagerAccount();
}
public class Executive : IApplicant
{
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public IAccount AccountProcessor { get; set; } = new ExecutiveAccount();
}

public interface IAccount
{
    Employee Create(IApplicant applicant);
}

public class Account : IAccount
{
    public Employee Create(IApplicant applicant)
    {
        var employee = new Employee
        {
            FirstName = applicant.FirstName,
            LastName = applicant.LastName,
            Email = $"{applicant.FirstName[..1]}{applicant.LastName}@acme.com"
        };
        return employee;
    }
}

public class ManagerAccount : IAccount
{
    public Employee Create(IApplicant applicant)
    {
        var employee = new Employee
        {
            FirstName = applicant.FirstName,
            LastName = applicant.LastName,
            Email = $"{applicant.FirstName[..1]}{applicant.LastName}@acme.com",
            IsManager = true
        };
        return employee;
    }
}

public class ExecutiveAccount: IAccount
{
    public Employee Create(IApplicant applicant)
    {
        var employee = new Employee
        {
            FirstName = applicant.FirstName,
            LastName = applicant.LastName,
            Email = $"{applicant.FirstName[..1]}{applicant.LastName}@acme.com",
            IsManager = true,
            IsExecutive = true
        };
        return employee;
    }
}