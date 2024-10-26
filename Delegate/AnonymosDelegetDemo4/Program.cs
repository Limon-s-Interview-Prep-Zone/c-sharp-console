using System;
using models.Employee;
namespace AnonymosDelegetDemo4
{

    class Program
    {
        public delegate string DelegateAnonymos(string name);
        static void Main(string[] args)
        {
            // anonymons demo
            DelegateAnonymos delegateAnonymos = delegate (string name)
            {
                return $"Hello {name} !!Welcome to  delegate with anonymos";
            };
            var greetings = delegateAnonymos("Limon");
            Console.WriteLine(greetings);

            //End of anonymons demo
            var p = new Employee();
            p.emp.Add(new Employee() { ID = 1, Name = "Limon", Gender = "Male", Salary = 30000 });
            p.AddEmployee();

            Predicate<Employee> predicateEmployee = new Predicate<Employee>(Employee.GetEmployee);
            var item = p.emp.Find(x => predicateEmployee(x));
            Console.WriteLine($"Name:{item.Name}\t Salary:{item.Salary}");

            // var itemAnonymos = p.emp.Find(x => x.Salary < 30000);
            // using delegate
            var itemAnonymos = p.emp.Find(delegate (Employee x)
            {
                return x.ID == 4;
            });

            Console.WriteLine($"Name:{itemAnonymos.Name}\t Salary:{itemAnonymos.Salary}");
        }
    }
}

//  anonymos method is a function which does not have a name;