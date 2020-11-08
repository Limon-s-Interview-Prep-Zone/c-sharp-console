using System;
using System.Collections.Generic;

namespace collections.GenericCollection
{
    class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Salary { get; set; }
        public List<Student> Students { get; set; }
        public Student()
        {
            Students = new List<Student>();
        }
    }

    class Employee
    {
        public int ID;
        public string Name;
        public string Gender;
        public int Salary;
    }

}