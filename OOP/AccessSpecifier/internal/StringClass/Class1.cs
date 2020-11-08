using System;

namespace StringClass
{
    public class AssemblyTwoClassI
    {
        public void Test()
        {
            InternalClass2 instance = new InternalClass2();
            Console.WriteLine(instance.id);
        }
    }
}
