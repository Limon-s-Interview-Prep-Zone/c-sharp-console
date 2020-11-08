using System;

namespace AccessKeyWord
{
    class People
    {
        public int Id;
        public string Name;

        public People(string name)
        {
            Console.WriteLine("I am base class constructor " + name);
        }
        public People(int Id, string Name)
        {
            this.Name = Name;
            this.Id = Id;
            Console.WriteLine($"Name={Name} Id:{Id} ");
        }

    }
    class Student : People
    {
        public string Dept;

        public Student(string name) : base(name)
        {

        }
        public Student(string dept, int Id, string Name) : base(Id, Name)
        {
            Dept = dept;
            Console.WriteLine($"Dept:{Dept}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("BCSE", 14203165, "limon");
            People p = new People(14203165, "LIMON");
            Student student1 = new Student("Rashedul Islam");
        }
    }
}
