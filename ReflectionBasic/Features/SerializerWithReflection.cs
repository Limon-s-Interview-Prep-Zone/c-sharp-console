using System.Text.Json;

namespace ReflectionBasic.Features;

public class SerializerWithReflection
{
    internal static void SerializeObject()
    {
        Student person = new Student { Name = "Limon", Age = 25 };
        Serializer serializer = new Serializer();
        string json = serializer.Serialize(person);
        Console.WriteLine($"Serialized JSON: {json}");
    }   
}

public class Student
{
    public string Name { get; set; }
    public int Age { get; set; }
}

public class Serializer
{
    public string Serialize(object obj)
    {
        var properties = obj.GetType().GetProperties();
        var dictionary = new Dictionary<string, object>();

        foreach (var property in properties)
        {
            dictionary[property.Name] = property.GetValue(obj);
        }

        return JsonSerializer.Serialize(dictionary);
    }
}