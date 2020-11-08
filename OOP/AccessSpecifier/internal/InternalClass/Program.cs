using System;
namespace InternalClass
{
    internal class AssemblyOneClassI
    {
        internal int ID = 999;
    }
    class Program
    {
        static void Main(string[] args)
        {
            AssemblyOneClassI instance = new AssemblyOneClassI();
            // Can access inetrnal member ID, AssemblyOneClassII and AssemblyOneClassI
            // are present in the same assembly            
            Console.WriteLine(instance.ID);
            InternalClass2 ic2 = new InternalClass2();
            Console.WriteLine("Name:" + ic2.name);
            Console.WriteLine("id:" + ic2.id);
        }
    }
}
