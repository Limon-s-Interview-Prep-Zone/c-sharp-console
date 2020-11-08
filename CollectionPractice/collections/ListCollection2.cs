using System;
using System.Collections.Generic;

namespace collections.GenericCollection
{
    class SortClass : IComparer<Employee>
    {
        public int Compare( Employee x,  Employee y)
        {
            return x.Name.CompareTo(y.Name);
        }
        public static int SortbyDelegate(Employee e1, Employee e2)
        {
            return e1.Gender.CompareTo(e2.Gender);
        }
    }
    class ListDemo2
    {
       
        public static void ListMethod()
        {
            //employe object//
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
            Employee emp5 = new Employee()
            {
                ID = 105,
                Name = "Hina",
                Gender = "Male",
                Salary = 7500
            };
            Employee emp6 = new Employee()
            {
                ID = 106,
                Name = "Tarun",
                Gender = "Male",
                Salary = 8500
            };

            //Add() AddRange(IEnumerable<T>)//
            List<Employee> listEmployees = new List<Employee>();
            listEmployees.Add(emp1);
            listEmployees.Add(emp2);
            listEmployees.Add(emp3);
            listEmployees.Add(emp4);

            List<Employee> AnotherlistEmployees = new List<Employee>();
            AnotherlistEmployees.Add(emp4);
            AnotherlistEmployees.Add(emp5);
            AnotherlistEmployees.Add(emp6);

            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(">>>>>>>>>>>>>Add() & AddRange()>>>>>>>>>>>>");
            Console.ResetColor();
            listEmployees.AddRange(AnotherlistEmployees);
            foreach (var em in listEmployees)
            {
                Console.WriteLine($"Id={em.ID} Name={em.Name} Gender={em.Gender} Salary={em.Salary}");
            }

            //Contain() Exist() Find() FindLast() FindAll() FindIndex() FindLastIndex()//contain
            if (listEmployees.Contains(emp2))
            {
                Console.WriteLine("\nContain()->\t Employee is found");
                Console.WriteLine($"Id={emp2.ID} Name={emp2.Name} Gender={emp2.Gender} Salary={emp2.Salary}");
            }
            else
                Console.WriteLine("\nContain()->\tEmployee not found");
            //Exists
            if (listEmployees.Exists(p => p.Name.StartsWith("S")))
            {
                Console.WriteLine("\nExist()\tEmployee is Exist");
            }
            else
                Console.WriteLine("\nExist()\tEmployee not found");

            //find
            var employee = listEmployees.Find(p => p.Gender == "Male");
            if (employee != null)
            {
                Console.WriteLine("\nFind()");
                Console.WriteLine($"Id={employee.ID} Name={employee.Name} Gender={employee.Gender} Salary={employee.Salary}");
            }
            else
                Console.WriteLine("\nEmployee not found");

            //FindLast
            var findLast = listEmployees.FindLast(p => p.Gender == "Male");
            Console.WriteLine("\nFindLast():");
            Console.WriteLine($"Id={findLast.ID} Name={findLast.Name} Gender={findLast.Gender} Salary={findLast.Salary}");
            //FindAll
            var employessAll = listEmployees.FindAll(p => p.Salary > 5000);
            if (employessAll != null)
            {
                Console.WriteLine("\nEmployee is found:FindAll()");
                foreach (var employeeall in employessAll)
                {
                    Console.WriteLine($"Id={employeeall.ID} Name={employeeall.Name} Gender={employeeall.Gender} Salary={employeeall.Salary}");
                }
            }
            else
                Console.WriteLine("\nEmployee not found:FindAll()");
            //FindIndex
            int findIndex = listEmployees.FindIndex(flast => flast.Gender == "Male");
            Console.WriteLine("\nEmployee Index:FindIndex()={0}", findIndex);

            //FindLastIndex
            int findlastIndex = listEmployees.FindLastIndex(flast => flast.Gender == "Male");
            Console.WriteLine("\nEmployee LastIndex: FindLastIndex()={0}", findlastIndex);

            // GetRange() Insert() InsertRange() Remove() & RemoveAll()& RemoveAt() //
            //GetRange()
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(">>>>>>>>>>>>>GetRange()>>>>>>>>>>>>");
            Console.ResetColor();
            List<Employee> empFromGetRanges = listEmployees.GetRange(1, 3);
            foreach (var empFromGetRange in empFromGetRanges)
            {
                Console.WriteLine($"Id={empFromGetRange.ID} Name={empFromGetRange.Name} Gender={empFromGetRange.Gender} Salary={empFromGetRange.Salary}");
            }
            //Remove() & RemoveAll()& RemoveAt()
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(">>>>>>>>>>>>>RemoveAll(lamda expression) & RemoveAt(Int index) &Remove(T value)>>>>>>>>>>>>");
            Console.ResetColor();
            listEmployees.Remove(emp1);
            listEmployees.RemoveAt(1);
            listEmployees.RemoveAll(e => e.Gender == "Male");
            foreach (var empFromGetRange in listEmployees)
            {
                Console.WriteLine($"Id={empFromGetRange.ID} Name={empFromGetRange.Name} Gender={empFromGetRange.Gender} Salary={empFromGetRange.Salary}");
            }

            //RemoveRange()
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(">>>>>>>>>>>>>RemoveRange(int index,numberofitem)>>>>>>>>>>>>");
            Console.ResetColor();
            listEmployees.RemoveRange(0, 1);
            foreach (var empFromGetRange in listEmployees)
            {
                Console.WriteLine($"Id={empFromGetRange.ID} Name={empFromGetRange.Name} Gender={empFromGetRange.Gender} Salary={empFromGetRange.Salary}");
            }
            // Insert() & InsertRange()
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(">>>>>>>>>>>>>Insert(int index,T value) & InsertRange(int index, <IEnumerable<T>>)>>>>>>>>>>>>");
            Console.ResetColor();
            listEmployees.Insert(0, emp1);
            listEmployees.InsertRange(0, AnotherlistEmployees);
            Console.WriteLine("Before Sorting");
            foreach (var empFromGetRange in listEmployees)
            {
                Console.WriteLine($"Id={empFromGetRange.ID} Name={empFromGetRange.Name} Gender={empFromGetRange.Gender} Salary={empFromGetRange.Salary}");
            }

             //Sort()//
            //SortedClass
            SortClass sc = new SortClass();
            listEmployees.Sort(sc);
            Console.WriteLine("After Sorting");
            foreach (var empFromGetRange in listEmployees)
            {
                Console.WriteLine($"Id={empFromGetRange.ID} Name={empFromGetRange.Name} Gender={empFromGetRange.Gender} Salary={empFromGetRange.Salary}");
            }
            //SortbyGender with delegate
            Comparison<Employee> comparison = new Comparison<Employee>(SortClass.SortbyDelegate);
            listEmployees.Sort(comparison);
            Console.WriteLine("After Sorting by delegtae");
            foreach (var empFromGetRange in listEmployees)
            {
                Console.WriteLine($"Id={empFromGetRange.ID} Name={empFromGetRange.Name} Gender={empFromGetRange.Gender} Salary={empFromGetRange.Salary}");
            }
 
            //TrueForAll() AsREadOnly() TrimExcess()//
            //TrueForAll(Lamda Expression)
            Console.WriteLine("TrueForAll()={0}" + listEmployees.TrueForAll(x => x.Salary > 5000));
            var readOnly = listEmployees.AsReadOnly();
            Console.WriteLine("Make employee list AsReadOnly()");
            foreach (var empFromGetRange in listEmployees)
            {
                Console.WriteLine($"Id={empFromGetRange.ID} Name={empFromGetRange.Name} Gender={empFromGetRange.Gender} Salary={empFromGetRange.Salary}");
            }
            Console.WriteLine(">>>>>>>>>>>>>Before TrimExcess()=>>>Total item={0}", listEmployees.Capacity);
            //TrimExcess
            listEmployees.TrimExcess();
            //Capasity
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(">>>>>>>>>>>>> After Use TrimExcess()=>>Use listEmployees.Capsity=>>>Total item={0}", listEmployees.Capacity);
            Console.ResetColor();
            //Clear()
            listEmployees.Clear();
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(">>>>>>>>>>>>>After Clear() total Iteam={0}", listEmployees.Count);
            Console.ResetColor();
        }
    }
}