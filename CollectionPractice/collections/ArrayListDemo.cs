using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CollectionPractice.collections
{
    class ArrayListDemo
    {
        public static void ArryListShow()
        {
            ArrayList al = new ArrayList();
            al.Add(12);
            al.Add("limon");
            al.Add(14203165);
            al.Add("BCSE");
            foreach (var item in al)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("\nRemove(object):");
            al.Remove("BCSE");
            foreach (var item in al)
            {
                Console.WriteLine(item);
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
            foreach (var item in al)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("\nCapasity:{0}", al.Capacity);

        }
    }
}
