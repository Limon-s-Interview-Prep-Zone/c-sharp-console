namespace Polymorphism;


// Base class
public class Report
{
    public virtual void Generate()
    {
    }
}

// Derived class for Sales Report
public class SalesReport : Report
{
    public override void Generate()
    {
        Console.WriteLine("Generating Sales Report...");
        // Additional logic specific to sales reporting
        Console.WriteLine("Total Sales: $5000");
    }
}

// Derived class for Inventory Report
public class InventoryReport : Report
{
    public override void Generate()
    {
        Console.WriteLine("Generating Inventory Report...");
        // Additional logic specific to inventory reporting
        Console.WriteLine("Total Items in Stock: 150");
    }
}

// Derived class for Employee Report
public class EmployeeReport : Report
{
    public override void Generate()
    {
        Console.WriteLine("Generating Employee Report...");
        // Additional logic specific to employee reporting
        Console.WriteLine("Total Employees: 25");
    }
}

// Main program to demonstrate polymorphism
internal static class ReportFactoryMethod
{
    public static void DriverCode()
    {
        Console.WriteLine("Polymorphism without abstract class:");
        // Creating an array of Report references
        Report[] reports = new Report[]
        {
            new SalesReport(),
            new InventoryReport(),
            new EmployeeReport()
        };

        // Generating reports using polymorphism
        foreach (var report in reports)
        {
            report.Generate();
            Console.WriteLine(); // For better readability
        }
    }
}