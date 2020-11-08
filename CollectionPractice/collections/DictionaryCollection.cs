
using System;
using System.Collections.Generic;
using System.Linq;

namespace collections.GenericCollection
{
    class DictionaryDemo
    {
        public static void DictionaryMethod()
        {
            //Add() & Employee Object//
            Employee emp1 = new Employee()
            {
                ID = 101,
                Name = "Pranaya",
                Gender = "Male",
                Salary = 20000
            };
            Employee emp2 = new Employee()
            {
                ID = 102,
                Name = "Priyanka",
                Gender = "Female",
                Salary = 30000
            };
            Employee emp3 = new Employee()
            {
                ID = 103,
                Name = "Anurag",
                Gender = "Male",
                Salary = 40000
            };

            //Add()
            Dictionary<int, Employee> dictionary = new Dictionary<int, Employee>();
            dictionary.Add(emp1.ID, emp1);
            dictionary.Add(emp2.ID, emp2);
            dictionary.Add(emp3.ID, emp3);
            //Find By Id//Find By id
            Employee em101 = dictionary[101];
            Console.WriteLine("Find Employee by Id:\nID = {0}, Name = {1}, Gender ={2}, Salary = {3}\n", em101.ID, em101.Name, em101.Gender, em101.Salary);

            //KeyValuePair<int,Employee>//KeyValuePair<int,Employee>
            Console.WriteLine("\nAll Employee From dictionary Using: KeyValuePair<int,Employee>");
            foreach (KeyValuePair<int, Employee> item in dictionary)
            {
                Console.WriteLine($"Key: {item.Key} Name= {item.Value.Name} Gender= {item.Value.Gender} Salary= {item.Value.Salary}");
            }

            //Get all employee using Values property//Get all employee using Values property
            Console.WriteLine("\nGet all employee using dictionary.Values property");
            foreach (var item in dictionary.Values)
            {
                Console.WriteLine($"Key: {item.ID} Name= {item.Name} Gender= {item.Gender} Salary= {item.Salary}");
            }

            //ContainsKey(key)
            Console.WriteLine("\nConatinsKey(key)");
            if (!dictionary.ContainsKey(101))
            {
                dictionary.Add(101, emp3);
            }
            else
            {
                Console.WriteLine("value already taken {0}\n", 101);
            }
            if (!dictionary.ContainsKey(104))
            {
                dictionary.Add(104, emp3);
                Console.WriteLine("value Succesfully Added {0}", 104);
            }
            else
            {
                Console.WriteLine("value already taken {0}", 104);
            }


            //TryGetValue()//
            Console.WriteLine("\nTryGetValue()");
            Employee emp777;
            if (dictionary.TryGetValue(104, out emp777))
            {
                Console.WriteLine("ID = {0}, Name = {1}, Gender ={2}, Salary = {3}",
                        emp777.ID, emp777.Name, emp777.Gender, emp777.Salary);
            }
            else
            {
                Console.WriteLine("Employee with Key = 777 is not found in the dictionary");
            }

            if (dictionary.ContainsKey(103))
            {
                Employee item = dictionary[103];
                Console.WriteLine($"\n Using dictionary[103] to convert employee object\nKey: {item.ID} Name= {item.Name} Gender= {item.Gender} Salary= {item.Salary}");
            }
            else
            {
                Console.WriteLine("Key does not exist in the dictionary");
            }
            var employeeByGender = dictionary.Count(g => g.Value.Gender == "Male");
            Console.WriteLine("\nTotal items in Employee Dictionary By Gender = {0}", employeeByGender);
            Console.WriteLine("\nTotal items in Employee Dictionary = {0}", dictionary.Count());

            //Remove(Tkey)//
            dictionary.Remove(103);
            Console.WriteLine("\nAfter removing 101 item = {0}", dictionary.Count());
            Employee item4 = dictionary[104];
            Console.WriteLine($"\n Using dictionary[104] to convert employee object\nKey: {item4.ID} Name= {item4.Name} Gender= {item4.Gender} Salary= {item4.Salary}");
            dictionary.Clear();
            Console.WriteLine("\nAfter Clear() Total item = {0}", dictionary.Count());

            //Array to Dictionary//
            Console.WriteLine("\nToDictionary():");
            Employee[] arr = new Employee[3];
            arr[0] = emp1;
            arr[1] = emp2;
            arr[2] = emp3;
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"index={i} value: {arr[i].Name}");
            }

            Dictionary<int, Employee> newDictionary = arr.ToDictionary(emp => emp.ID, emp => emp);
            foreach (KeyValuePair<int, Employee> item in newDictionary)
            {
                Console.WriteLine($"Key: {item.Key} Name= {item.Value.Name} Gender= {item.Value.Gender} Salary= {item.Value.Salary}");
            }
            Employee[] dicToarray = new Employee[newDictionary.Count];
            newDictionary.Values.CopyTo(dicToarray, 0);

            var EmpList = new List<Employee>(){
                emp1,emp2,emp3
            };
            foreach (var item in EmpList)
            {
                Console.WriteLine($"{item.Name}\t {item.Salary}");
            }
            var ListToDictionary = EmpList.Distinct().ToDictionary(emp => emp.ID, emp => emp);
            foreach (KeyValuePair<int, Employee> item in ListToDictionary)
            {
                Console.WriteLine($"Key: {item.Key} Name= {item.Value.Name} Gender= {item.Value.Gender} Salary= {item.Value.Salary}");
            }
            var DictionaryToList = new List<Employee>(ListToDictionary.Values);
            foreach (var item in DictionaryToList)
            {
                Console.WriteLine($"{item.Name}\t {item.Salary}");
            }

            var dict = new Dictionary<String, Double>();
            dict.Add("four", 4);
            dict.Add("three", 3);
            dict.Add("two", 2);
            dict.Add("five", 5);
            dict.Add("one", 1);
        }

    }
}