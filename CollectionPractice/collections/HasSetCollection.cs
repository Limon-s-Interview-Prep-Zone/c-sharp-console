using System;
using System.Collections.Generic;
using System.Linq;

namespace collections.GenericCollection
{
    class HasSetDemo
    {
        public static void HasSetMethod()
        {
            //HashSetEmployee Object//
            Employee emp1 = new Employee()
            {
                ID = 101,
                Name = "Pranaya",
                Gender = "Female",
                Salary = 5000
            };
            Employee emp2 = new Employee()
            {
                ID = 102,
                Name = "Priyanka",
                Gender = "Female",
                Salary = 7000
            };
            Employee emp3 = new Employee()
            {
                ID = 103,
                Name = "Anurag",
                Gender = "Male",
                Salary = 5500
            };
            Employee emp4 = new Employee()
            {
                ID = 104,
                Name = "Sambit",
                Gender = "Male",
                Salary = 6500
            };
            HashSet<Employee> hasSet = new HashSet<Employee>();
            hasSet.Add(emp1);
            hasSet.Add(emp2);
            hasSet.Add(emp3);
            hasSet.Add(emp4);
            Console.WriteLine("All value:");
            foreach (var item in hasSet)
            {
                Console.WriteLine($"Id:{item.ID} Name:{item.Name} Gender:{item.Gender} Salary:{item.Salary}");
            }
            //Remove()
            hasSet.Remove(emp1);
            Console.WriteLine("\nAfter removing:");
            foreach (var item in hasSet)
            {
                Console.WriteLine($"Id:{item.ID} Name:{item.Name} Gender:{item.Gender} Salary:{item.Salary}");
            }
            // RemoveWhere(p => p.Gender == "Male")
            var newhasSet = hasSet.RemoveWhere(p => p.Gender == "Male");
            Console.WriteLine("\nRemoveWhere(p => p.Gender == Male)");
            foreach (var item in hasSet)
            {
                Console.WriteLine($"Id:{item.ID} Name:{item.Name} Gender:{item.Gender} Salary:{item.Salary}");
            }
            //Count
            Console.WriteLine("Total Item Before clear:{0}", hasSet.Count);
            hasSet.Clear();
            Console.WriteLine("Total Item after clear:{0}", hasSet.Count);

            //HashSetToArray//
            Employee[] arr = new Employee[4];
            arr[0] = emp1;
            arr[1] = emp2;
            arr[2] = emp3;
            arr[3] = emp4;

            Console.WriteLine("Arry To HasSet");
            HashSet<Employee> arrToHasSet = new HashSet<Employee>(arr);
            foreach (var item in arrToHasSet)
            {
                Console.WriteLine($"Id:{item.ID} Name:{item.Name} Gender:{item.Gender} Salary:{item.Salary}");
            }
            Console.WriteLine("HasSet to array");
            Employee[] hashsetToArray = new Employee[4];
            hashsetToArray = arrToHasSet.ToArray();
            foreach (var item in hashsetToArray)
            {
                Console.WriteLine($"Id:{item.ID} Name:{item.Name} Gender:{item.Gender} Salary:{item.Salary}");
            }
        }
    }
}