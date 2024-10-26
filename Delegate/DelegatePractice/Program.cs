using System;
using System.Collections.Generic;

namespace DelegatePractice
{
    //single cast Class//
    public delegate void AddDelegate(int a,int b);
    public delegate string GreetingsMessage(string name);
    class SingleCastDelegate
    {
        public void Add(int x, int y)
        {
            Console.WriteLine(@"The Sum of {0} and {1}, is {2} ", x, y, (x + y));
        }
        //Static Method
        public static string Greetings(string name)
        {
            return "Hello @" + name;
        }
    }

    //multicast basic 
    public delegate void MathDelegate(int a, int b);

    //Multicast Basic class  //
    class Multicast
    {
        
        public static void Add(int x, int y)
        {
            Console.WriteLine("THE SUM IS : " + (x + y));
        }
        public static void Sub(int x, int y)
        {
            Console.WriteLine("THE SUB IS : " + (x - y));
        }
        public void Mul(int x, int y)
        {
            Console.WriteLine("THE MUL IS : " + (x * y));
        }
        public void Div(int x, int y)
        {
            Console.WriteLine("THE DIV IS : " + (x / y));
        }
    }

    //Multicast with return type class//
    public delegate int ReturnDelegate();
    public delegate void ReturnDelegateOUt(out int num,out string name);
    class ReturnType
    {
        public static int Method1()
        {
            return 1;
        }
        public static int Method2()
        {
            return 2;
        }
        //Return with out parameter
        public static void OutMethod1(out int Id ,out string UserName)
        {
            Id = 101;
            UserName = "Tareque";
        }
        public static void OutMethod2(out int Id, out string UserName)
        {
            Id = 10065;
            UserName = "Limon";
        }
    }

    public delegate bool EligibleToPromotion(Employee employee);
    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Experience { get; set; }
        public int Salary { get; set; }

        public static void PromoteEmployee(List<Employee> employee,EligibleToPromotion eligibleToPromotion)
        {
            foreach (var emp in employee)
            {
                if (eligibleToPromotion(emp))
                {
                    Console.WriteLine("Employee {0} Promoted with sallery {1}", emp.Name,emp.Salary);
                }
            }
        }
        public static bool Promote(Employee employee)
        {
            if (employee.Salary > 10000)
                return true;
           else
             return false;
        }
    }

    class Program
	{
        static void Main(string[] args)
		{

            //Single cast Delegate explanation//
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("******Single Cast with Basic Explanation********");
            Console.ResetColor();
            SingleCastDelegate sobj = new SingleCastDelegate();
            AddDelegate ad = sobj.Add;
            ad.Invoke(100, 100);
            GreetingsMessage gd = new GreetingsMessage(SingleCastDelegate.Greetings);
            // GreetingsMessage gd = new GreetingsMessage(SingleCastDelegate.Greetings);
            string name= gd.Invoke("Limon");
            Console.WriteLine(name);

            //Multicast Basic explanation//
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("******Multicast with Basic Explanation********");
            Console.ResetColor();
            Multicast obj = new Multicast();
            MathDelegate md = Multicast.Add;
            MathDelegate mdSub = Multicast.Sub;
            MathDelegate mdMul = obj.Mul;
            MathDelegate mdDiv = obj.Div;
            MathDelegate mainMd = md + mdSub + mdMul + mdDiv;
            mainMd.Invoke(10, 10);
            mainMd -= mdSub;
            Console.WriteLine($"After removing {mdSub}");
            mainMd.Invoke(20, 50);

            //Multicast with return type//
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("******Multicast with return type********");
            Console.ResetColor();
            // ReturnType rt = new ReturnType();
            ReturnDelegate rd = ReturnType.Method1;
            rd += ReturnType.Method2;
            int valueGet=rd();
            Console.WriteLine("Return Value:{0}",valueGet);

            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("******Multicast with Out type********");
            Console.ResetColor();

            ReturnDelegateOUt rdo = ReturnType.OutMethod1;
            rdo += ReturnType.OutMethod2;
            int IdFromOut = -1;
            string UserNameFromOut = null;

            rdo(out IdFromOut, out UserNameFromOut);
            Console.WriteLine($"Value from Output parameter Id: {IdFromOut} Name:{UserNameFromOut}");

            //
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("******Multicast with RealLife example********");
            Console.ResetColor();
            Employee emp1 = new Employee()
            {
                ID = 101,
                Name = "Pranaya",
                Gender = "Male",
                Experience = 5,
                Salary = 10000
            };
            Employee emp2 = new Employee()
            {
                ID = 102,
                Name = "Priyanka",
                Gender = "Female",
                Experience = 10,
                Salary = 20000
            };
            Employee emp3 = new Employee()
            {
                ID = 103,
                Name = "Anurag",
                Experience = 15,
                Salary = 30000
            };
            List<Employee> listEmployess = new List<Employee>() { emp1, emp2, emp3 };
            // EligibleToPromotion eligbleDelegate = Employee.Promote;

           //Employee.PromoteEmployee(listEmployess, eligbleDelegate);
            Employee.PromoteEmployee(listEmployess,x=>x.Salary>=10000);

        }
    }
}
