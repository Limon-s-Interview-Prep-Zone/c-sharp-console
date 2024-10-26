namespace InheritanceApp.CompanyStructure;

// Base class for Employee
public abstract class Employee
{
    public Guid Id { get; private set; }
    public string Name { get; set; }
    public decimal Salary { get; set; }

    protected Employee(string name, decimal salary)
    {
        Id = Guid.NewGuid();
        Name = name;
        Salary = salary;
    }

    public abstract void DisplayInfo();

    // New method to display Salary and Name
    protected void DisplaySalaryAndName()
    {
        Console.WriteLine($"Id: {Id} Name: {Name}, Salary: {Salary}");
    }
}

// Interface for Manager role
public interface IManager
{
    void ManageTeam();
}

// Interface for Intern role
public interface IIntern
{
    void Learn();
}

// Interface for Technician role
public interface ITechnician
{
    void FixIssues();
}

// Department class
public class Department
{
    public string DepartmentName { get; set; }
    public List<Employee> Employees { get; set; }

    public Department(string departmentName)
    {
        DepartmentName = departmentName;
        Employees = new List<Employee>();
    }

    public void AddEmployee(Employee employee)
    {
        Employees.Add(employee);
    }

    public void DisplayEmployees()
    {
        Console.WriteLine($"Employees in {DepartmentName} Department:");
        foreach (var emp in Employees)
        {
            emp.DisplayInfo();
        }
    }
}

// Manager class implementing IManager interface
public class Manager : Employee, IManager
{
    public Manager(string name, decimal salary) : base(name, salary)
    {
    }

    public override void DisplayInfo()
    {
        // Call the method to display Salary and Name
        DisplaySalaryAndName();
    }

    public void ManageTeam()
    {
        Console.WriteLine($"{Name} is managing the team.");
    }
}

// Intern class implementing IIntern interface
public class Intern : Employee, IIntern
{
    public Intern(string name, decimal salary) : base(name, salary)
    {
    }

    public override void DisplayInfo()
    {
        // Call the method to display Salary and Name
        DisplaySalaryAndName();
    }

    public void Learn()
    {
        Console.WriteLine($"{Name} is learning from the team.");
    }
}

// Technician class implementing ITechnician interface
public class Technician : Employee, ITechnician
{
    public Technician(string name, decimal salary) : base(name, salary)
    {
    }

    public override void DisplayInfo()
    {
        // Call the method to display Salary and Name
        DisplaySalaryAndName();
    }

    public void FixIssues()
    {
        Console.WriteLine($"{Name} is fixing issues.");
    }
}

// Usage example
public class DriverClass
{
    public static void DriverCode()
    {
        // Create a department
        var techDepartment = new Department("Technology");

        // Create employees using polymorphism
        var manager = new Manager("Alice", 90000);
        var intern = new Intern("Bob", 30000);
        var technician = new Technician("Charlie", 60000);

        // Add employees to the department
        techDepartment.AddEmployee(manager);
        techDepartment.AddEmployee(intern);
        techDepartment.AddEmployee(technician);

        // Display department employees
        techDepartment.DisplayEmployees();

        // Call specific interface methods
        manager.ManageTeam();
        intern.Learn();
        technician.FixIssues();
    }
}