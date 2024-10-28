
// See https://aka.ms/new-console-template for more information

using System.Reflection;

namespace ReflectionBasic.Features;

public class Example
{
    public int Value { get; set; }
}

internal class AssemblyExample
{
    internal static void DriverCode()
    {
        Example example = new Example();
        Type type = Type.GetType("Example"); // Get type from instance

        Console.WriteLine("Full Name: " + type?.Name);
        Console.WriteLine("Full Name: " + type?.FullName);
        Console.WriteLine("Namespace: " + type?.Namespace);
        Console.WriteLine("Is Class: " + type?.IsClass);
        type.GetMethod("limon");
        
        Type typeFromTypeof = typeof(Example);
        Assembly assemblyFromTypeof = typeFromTypeof.Assembly;
        Console.WriteLine($"Assembly Name (typeof): {assemblyFromTypeof.GetName().Name}"); // Output: Assembly Name (typeof): TypeExamples

        // Creating an instance of Example
        Example exampleInstance = new Example();

        // Using GetType to get the runtime type of the instance
        Type typeFromGetType = exampleInstance.GetType();
        Assembly assemblyFromGetType = typeFromGetType.Assembly;
        Console.WriteLine($"Assembly Name (GetType): {assemblyFromGetType.GetName().Name}"); // Output: Assembly Name (GetType): TypeExamples
        
        Assembly assembly = type.Assembly;

        Console.WriteLine($"Assembly Full Name: {assembly.FullName}");
        Console.WriteLine($"Assembly Location: {assembly.Location}");
        
        Assembly entryAssembly = Assembly.GetEntryAssembly();
        Assembly executeAssembly = Assembly.GetExecutingAssembly();
        Console.WriteLine($"Executing:{executeAssembly}");
        Console.WriteLine($"FullName:{Assembly.GetExecutingAssembly().FullName}");
        // Console.WriteLine($"Executing:{executeAssembly.GetModule().Name}");

        if (entryAssembly != null)
        {
            Console.WriteLine($"Entry Assembly: {entryAssembly.GetName().Name}");

            // Get version information
            Version version = entryAssembly.GetName().Version;
            Console.WriteLine($"Version: {version}");
        }
        else
        {
            Console.WriteLine("This is not an entry assembly (e.g., a library).");
        }

    }
}