using System;
using System.Collections.Generic;

namespace Models.Employee
{
    public delegate bool DelegateEligableToPromotion(Employee employee);
    public partial class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public double Salary { get; set; }
        public List<Employee> emp;
        public Employee()
        {
            emp = new List<Employee>();
        }
    }
    public partial class Employee
    {
        public void AddEmployee()
        {
            emp.Add(new Employee() { ID = 1, Name = "Limon", Gender = "Male", Salary = 30000 });
            emp.Add(new Employee() { ID = 2, Name = "Lama", Gender = "Female", Salary = 20000 });
            emp.Add(new Employee() { ID = 3, Name = "Lamia", Gender = "Female", Salary = 27000 });
            emp.Add(new Employee() { ID = 4, Name = "Monisha", Gender = "Female", Salary = 22000 });
            // return emp;
        }

        public static void PromoteEmployee(List<Employee> empList, DelegateEligableToPromotion eligableToPromotion)
        {
            foreach (var item in empList)
            {
                if (eligableToPromotion(item))
                {
                    Console.WriteLine($"EMployee Name:{item.Name}\t Salary:{item.Salary}");
                }

            }
        }

        public static bool Promote(Employee employee)
        {
            if (employee.Salary > 20000) return true;
            return false;
        }
    }
}