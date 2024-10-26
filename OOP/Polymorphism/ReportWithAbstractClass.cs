namespace Polymorphism;

public abstract class ReportWithAbstractClass
{
    // Abstract method that must be implemented by derived classes
    public abstract void Generate();
}

// Base class

// Derived class for Sales Report
internal class SalesReportWithAbstractClass : ReportWithAbstractClass
{
    public override void Generate()
    {
        Console.WriteLine("Generating Sales Report...");
        // Additional logic specific to sales reporting
        Console.WriteLine("Total Sales: $5000");
    }
}

// Derived class for Inventory Report
internal class InventoryReportWithAbstractClass : ReportWithAbstractClass
{
    public override void Generate()
    {
        Console.WriteLine("Generating Inventory Report...");
        // Additional logic specific to inventory reporting
        Console.WriteLine("Total Items in Stock: 150");
    }
}

// Derived class for Employee Report
internal class EmployeeReportWithAbstractClass : ReportWithAbstractClass
{
    public override void Generate()
    {
        Console.WriteLine("Generating Employee Report...");
        // Additional logic specific to employee reporting
        Console.WriteLine("Total Employees: 25");
    }
}

// Main program to demonstrate polymorphism
internal static class ReportWithAbstractClassFactoryMethod
{
    public static void DriverCode()
    {
        Console.WriteLine("Polymorphism with abstract class:");
        // Creating an array of Report references
        ReportWithAbstractClass[] reports = new ReportWithAbstractClass[]
        {
            new SalesReportWithAbstractClass(),
            new InventoryReportWithAbstractClass(),
            new EmployeeReportWithAbstractClass()
        };

        // Generating reports using polymorphism
        foreach (var report in reports)
        {
            report.Generate();
            Console.WriteLine(); // For better readability
        }
    }
}