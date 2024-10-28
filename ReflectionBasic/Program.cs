using System.Text.Json;
using ReflectionBasic.Features;

// AssemblyExample.DriverCode();
// LateBinding.LateBindingWithDynamic();
// LateBinding.LateBindingWithMethodInvoke();
// SerializerWithReflection.SerializeObject();
//
// CustomAttribute.DriverCode();

EnumReflection();
void EnumReflection()
{
    Dictionary<Tkey, int> dictionary = new();
    if (typeof(Tkey).IsEnum)
    {
        int i = 0;
        foreach (Tkey key in Enum.GetValues(typeof(Tkey)))
        {
            dictionary[key] = ++i;
        }
        Console.WriteLine(JsonSerializer.Serialize(dictionary));
    }
}

public enum Tkey
{
    High,
    Low,
    Medium
}

