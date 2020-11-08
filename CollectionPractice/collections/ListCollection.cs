using System;
using System.Collections.Generic;

namespace collections.GenericCollection
{
    class ListDemo
    {
        public static void ListShow()
        {
            Student stu = new Student();
            stu.Students.Add(
                new Student()
                {
                    ID = 101,
                    Name = "Pranaya",
                    Gender = "Female",
                    Salary = 5000
                }
             );
            stu.Students.Add(
                new Student()
                {
                    ID = 102,
                    Name = "Priyanka",
                    Gender = "Female",
                    Salary = 7000
                }
             );
            stu.Students.Add(
                new Student()
                {
                    ID = 103,
                    Name = "Anurag",
                    Gender = "Male",
                    Salary = 5500
                }
             );
            stu.Students.Add(
                new Student() { ID = 1, Name = "Limon", Gender = "Male", Salary = 30000 }
             );
            stu.Students.Add(
                new Student() { ID = 1, Name = "Limon", Gender = "Male", Salary = 30000 }
             );

            /* Add range */
            Student stu1 = new Student()
            {
                ID = 107,
                Name = "lama",
                Gender = "Female",
                Salary = 45000
            };
            List<Student> stulist = new List<Student>();
            stulist.Add(stu1);

            stu.Students.AddRange(stulist);
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(">>>>>>>>>>>>>Add() & AddRange()>>>>>>>>>>>>");

            Console.ResetColor();
            foreach (var em in stu.Students)
            {
                Console.WriteLine($"Id={em.ID} Name={em.Name} Gender={em.Gender} Salary={em.Salary}");
            }
        }
    }
}