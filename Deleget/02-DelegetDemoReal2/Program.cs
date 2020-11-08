using System;
using System.Collections.Generic;
using Models.Employee;

namespace DelegetDemoReal2
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Employee();
            p.emp.Add(new Employee() { ID = 1, Name = "Limon", Gender = "Male", Salary = 30000 });
            p.AddEmployee();
            // Employee.PromoteEmployee(p.emp);
            Employee em1 = new Employee()
            {
                ID = 102,
                Name = "Biplob",
                Gender = "Male",
                Salary = 50000
            };

            // List<Employee> p = new List<Employee>();
            // p.Add(new Employee() { ID = 2, Name = "Lama", Gender = "Female", Salary = 20000 });
            // p.Add(new Employee() { ID = 3, Name = "Lamia", Gender = "Female", Salary = 27000 });
            // p.Add(new Employee() { ID = 4, Name = "Monisha", Gender = "Female", Salary = 22000 });
            // p.Add(new Employee() { ID = 5, Name = "Likhon", Gender = "Male", Salary = 30000 });

            p.emp.Add(em1);
            DelegateEligableToPromotion delegateEligableToPromotion = new DelegateEligableToPromotion(Employee.Promote);
            Employee.PromoteEmployee(p.emp, delegateEligableToPromotion);

            foreach (var item in p.emp)
            {
                Console.WriteLine($"Name:{item.Name}\t Salary:{item.Salary}");
            }
            Console.WriteLine("Using Labda Function &&& Salary less Than 30000");
            Employee.PromoteEmployee(p.emp, x => x.Salary < 30000);
        }
    }
}

//  passing object
// labda fuction: Insted of passing delegate and function we can simply aquire this by passing lamda expression