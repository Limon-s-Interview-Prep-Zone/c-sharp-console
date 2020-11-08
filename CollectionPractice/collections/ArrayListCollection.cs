using System;
using System.Collections;

namespace collections.NonGenericCollection
{
    public class ArrayListCollection
    {
        public static void ArrayListShow()
        {
            ArrayList al = new ArrayList();
            // to add new object
            al.Add(12);
            al.Add("limon");
            al.Add(14203165);
            al.Add("BCSE");
            foreach (var item in al)
            {
                Console.WriteLine($"Item:{item}");
            }
            Console.WriteLine("\nRemove(object):");
            al.Remove("BCSE");
            foreach (var item in al)
            {
                Console.WriteLine($"{item}");
            }
            Console.WriteLine("\nRemoveAt(index)");
            al.RemoveAt(1);
            foreach (var item in al)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("\nInsert(int index,object)");
            al.Insert(1, "Limon");

            al.Insert(3, "BCSE");
            for (int i = 0; i < al.Count; i++)
            {
                Console.WriteLine($"index:{i} value:{al[i]}");
            }
            Console.WriteLine(@"\n Capasity:{0}", al.Capacity);
        }
    }
}