using System;

namespace GenericDelegetDemo5
{
    public delegate double AddNumber1Delegate(int no1, float no2, double no3);
    public delegate void AddNumber2Delegate(int no1, float no2, double no3);
    public delegate bool CheckLengthDelegate(string name);
    public class GenericDelegateDemo
    {

        public static double AddNumber1(int no1, float no2, double no3)
        {
            return no1 + no2 + no3;
        }
        public static void AddNumber2(int no1, float no2, double no3)
        {
            Console.WriteLine(no1 + no2 + no3);
        }
        public static bool CheckLength(string name)
        {
            if (name.Length > 5)
                return true;
            return false;
        }
    }

    class Program
    {

        static void Main(string[] args)
        {
            GenericDelegateDemo p = new GenericDelegateDemo();
            AddNumber1Delegate obj1 = new AddNumber1Delegate(GenericDelegateDemo.AddNumber1);
            double Result = obj1.Invoke(100, 125.45f, 456.789);
            Console.WriteLine(Result);
            AddNumber2Delegate obj2 = new AddNumber2Delegate(GenericDelegateDemo.AddNumber2);
            obj2.Invoke(50, 255.45f, 123.456);
            CheckLengthDelegate obj3 = new CheckLengthDelegate(GenericDelegateDemo.CheckLength);
            bool Status = obj3.Invoke("Limon");
            Console.WriteLine(Status);
            Console.WriteLine($"Using gerneric class");
            Func<int, float, double, double> gob1 = new Func<int, float, double, double>(GenericDelegateDemo.AddNumber1);
            var gResult = gob1.Invoke(100, 125.45f, 456.789);
            Console.WriteLine("Genriec: AddNumber1=>" + gResult);

            Action<int, float, double> gob2 = new Action<int, float, double>(GenericDelegateDemo.AddNumber2);
            gob2.Invoke(100, 125.45f, 456.789);
            Predicate<string> golb3 = new Predicate<string>(GenericDelegateDemo.CheckLength);
            var gstatus = golb3.Invoke("limon");
            Console.WriteLine("Status:" + gstatus);
            Console.WriteLine($"End Using gerneric class");
            Console.WriteLine($"LAMBDA and Using gerneric class");
            Func<int, float, double, double> lob1 = (x, y, z) =>
            {
                return x + y + z;
            };
            double lResult = lob1.Invoke(100, 125.45f, 456.789);
            Console.WriteLine(lResult);

            Action<int, float, double> lob2 = (x, y, z) =>
            {
                Console.WriteLine(x + y + z);
            };
            lob2.Invoke(50, 255.45f, 123.456);
            Console.WriteLine($"End LAMBDA and Using gerneric class");
            Console.ReadKey();
        }


    }
}
