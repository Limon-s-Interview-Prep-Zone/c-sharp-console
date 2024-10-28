namespace ReflectionBasic.Features;

public class CustomAttribute
{
    public static void DriverCode()
    {
        Console.WriteLine("\nCustomAttribute");
        Type type = typeof(User);

        // Retrieve and print the DisplayName for the class
        var classAttribute = (DisplayNameAttribute)Attribute.GetCustomAttribute(type, typeof(DisplayNameAttribute));
        if (classAttribute != null)
        {
            Console.WriteLine($"Class Display Name: {classAttribute.Name}");
        }

        // Iterate over the properties and print their DisplayNames
        foreach (var prop in type.GetProperties())
        {
            var propAttribute = (DisplayNameAttribute)Attribute.GetCustomAttribute(prop, typeof(DisplayNameAttribute));
            if (propAttribute != null)
            {
                Console.WriteLine($"Property: {prop.Name}, Display Name: {propAttribute.Name}");
            }
        }
    }
}

// Step 1: Define a custom DisplayName attribute
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property)]
public class DisplayNameAttribute : Attribute
{
    public string Name { get; }

    // Constructor to set the custom name
    public DisplayNameAttribute(string name)
    {
        Name = name;
    }
}

// Step 2: Apply the DisplayName attribute to a class and its properties
[DisplayName("User Entity")]
public class User
{
    [DisplayName("User Identifier")]
    public int Id { get; set; }

    [DisplayName("User Full Name")]
    public string Name { get; set; }
}