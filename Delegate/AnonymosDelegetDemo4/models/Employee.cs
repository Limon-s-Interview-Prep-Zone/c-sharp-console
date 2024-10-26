using System;
using System.Collections.Generic;

namespace models.Employee
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
        public List<Employee> AddEmployee()
        {
            emp.Add(new Employee() { ID = 1, Name = "Limon", Gender = "Male", Salary = 30000 });
            emp.Add(new Employee() { ID = 2, Name = "Lama", Gender = "Female", Salary = 20000 });
            emp.Add(new Employee() { ID = 3, Name = "Lamia", Gender = "Female", Salary = 27000 });
            emp.Add(new Employee() { ID = 4, Name = "Monisha", Gender = "Female", Salary = 22000 });
            return emp;
        }

        public static bool GetEmployee(Employee employee)
        {
            return employee.Salary == 30000;
        }

    }
}