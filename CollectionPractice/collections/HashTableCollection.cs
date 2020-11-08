using System;
using System.Collections;

namespace collections.NonGenericCollection
{
    class HashTableDemo
    {
        public static void HashTableShow()
        {
            Hashtable ht = new Hashtable();
            ht.Add(1, "limon");
            ht.Add(2, "sihab");
            ht.Add(3, "Tonmoy");
            ht.Add("Room-1", "Tarque");
            ht.Add("Room-2", "Owakil");

            foreach (var item in ht.Keys)
            {
                Console.WriteLine($"Key:{item}\t Value:{ht[item]}");
            }
            Console.WriteLine("Iterate based on values");
            foreach (var item in ht.Values)
            {
                Console.WriteLine($"Value:{item} ");
            }
            var key = "Room-1";
            if (ht.ContainsKey(key))
                Console.WriteLine($"Key found---{key}");
            else
                Console.WriteLine($"Key not found---{key}");

            var value = "Room-1";
            if (ht.ContainsValue(value))
                Console.WriteLine($"Value found---{value}");
            else
                Console.WriteLine($"Value not found---{value}");
        }
    }
}