using System;

namespace SealedClass
{
    public class Employee
    {
        protected int Eid, Eage;
        protected string Ename, Eaddress;
        public virtual void GetEmployeeData()
        {
            Console.WriteLine("ENTER EMPLOYEE DETAILS:");
            Console.WriteLine("ENTER THE ID");
            Eid = int.Parse(Console.ReadLine());
            Console.WriteLine("ENTER THE NAME");
            Ename = Console.ReadLine();
            Console.WriteLine("ENTER THE ADDRESS");
            Eaddress = Console.ReadLine();
            Console.WriteLine("ENTER THE AGE");
            Eage = int.Parse(Console.ReadLine());
        }
        public virtual void DisplayEmployeeData()
        {
            Console.WriteLine("\nEMPLOEE DETAILS ARE:");
            Console.WriteLine("EMPLOYEE ID IS: " + Eid);
            Console.WriteLine("EMPLOYEE NAME IS: " + Ename);
            Console.WriteLine("EMPLOYEE ADDRESS IS:" + Eaddress);
            Console.WriteLine("EMPLOYEE AGE IS : " + Eage);
        }
    }
    public sealed class Manager : Employee
    {
        double Bonus, CA;
        public override void GetEmployeeData()
        {
            Console.WriteLine("ENTER MANAGER DETAILS:");
            Console.WriteLine("ENTER THE ID");
            Eid = int.Parse(Console.ReadLine());
            Console.WriteLine("ENTER THE NAME");
            Ename = Console.ReadLine();
            Console.WriteLine("ENTER THE BONUS");
            Bonus = double.Parse(Console.ReadLine());
            Console.WriteLine("ENTER THE CA");
            CA = Convert.ToDouble(Console.ReadLine());
        }
        public override void DisplayEmployeeData()
        {
            Console.WriteLine("MANAGER DETAILS ARE:");
            Console.WriteLine("EMPLOYEE ID IS: " + Eid);
            Console.WriteLine("EMPLOYEE NAME IS: " + Ename);
            Console.WriteLine("MANAGER BONUS IS: " + Bonus);
            Console.WriteLine("MANAGER CA IS : " + CA);
        }
    }
    class d : Employee
    {
        public sealed override void DisplayEmployeeData()
        {
            Console.WriteLine("Class-D");
        }
    }
    class E :d
    {
        // can not override because the class is sealed 
        // but seal method can be accesiable
        // public sealed override void DisplayEmployeeData()
        // {
        //     Console.WriteLine("Class-D");
        // }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Manager manager = new Manager();
            var d = new d();
            var e = new E();
            d.DisplayEmployeeData();
            // manager.GetEmployeeData();
            manager.DisplayEmployeeData();
            // seal method can inherit but can not override
            e.DisplayEmployeeData();
        }
    }
}
// Seal class can not get inherit that totally oposite as abstract class.
// seal method can not be overriding but can inherit.