using System.Reflection;

namespace ReflectionBasic.Features;

public static  class LateBinding
{
    internal static void LateBindingWithDynamic()
    {
        dynamic person = Activator.CreateInstance(typeof(Person))!;

        // No compile-time type checking, everything is resolved at runtime.
        person.SayHello(); // Output: Hello, world!

        string name = person.GetName();
        Console.WriteLine(name); // Output: John Doe
    }

    internal static void LateBindingWithMethodInvoke()
    {
        // Create an instance of the 'Person' class using Activator.
        var person = Activator.CreateInstance(typeof(Person));

        // Get the private method 'SecretMessage' using reflection.
        MethodInfo method = typeof(Person).GetMethod("SecretMessage",
            BindingFlags.NonPublic | BindingFlags.Instance);

        if (method != null)
        {
            // Invoke the private method on the 'person' instance.
            method.Invoke(person, new object[]{"Milestone completed"}); // Output: This is a private message.
        }

        // Invoke a public method to get the name.
        MethodInfo getNameMethod = typeof(Person).GetMethod("GetName");
        var name = getNameMethod.Invoke(person, null);
        Console.WriteLine(name); // Output: John Doe
    }
}

public class Person
{
    public void SayHello()
    {
        Console.WriteLine("Hello, world!");
    }
    
    private void SecretMessage(string message)
    {
        Console.WriteLine($"You have got a secret message:{message}");
    }

    public string GetName() => "John Doe";
}