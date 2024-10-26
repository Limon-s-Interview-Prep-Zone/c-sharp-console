namespace Polymorphism;

public class StaticPolymorphism
{
    // Method for adding two integers
    internal int Add(int a, int b)
    {
        return a + b;
    }

    // Overloaded method for adding three integers
    internal int Add(int a, int b, int c)
    {
        return a + b + c;
    }   
}

public class StaticPolymorphismDriverClass
{
    internal static void DiverFunction()
    {
        Console.WriteLine("Static Polymorphism");
        StaticPolymorphism math = new StaticPolymorphism();
        Console.WriteLine(math.Add(5, 3));        // Calls Add(int, int)
        Console.WriteLine(math.Add(5, 3, 2));     // Calls Add(int, int, int)
    }
}