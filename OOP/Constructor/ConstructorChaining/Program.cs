using System;

namespace ConstructorChaining
{
    class Student
    {
        public int Id;
        public string Name;
        // public string Dept;

        private Student(int id, string name)
        {
            Id = id;
            Name = name;
        }
        public Student(string dept, int id, string name) : this(id, name)
        {

            Console.WriteLine("Constructor-Chaining:id:{0}\tName:{1}\t Dept:{2}", id, name, dept);
        }

        ~Student()
        {
            Console.WriteLine("Studen is destroyed");
        }
    }

    public class ChainingConstructor
    {
        public int length, height;
        public double width;
        private ChainingConstructor(int length, double width)
        {
            Console.WriteLine("Private 1st Constructor:>>>>:length:{0},length:{1}", length, width);
            this.length = length;
            this.width = width;
        }
        public ChainingConstructor(int length, double width, int height) : this(length, width)
        {
            this.height = height;
            Console.WriteLine("Public 2nd Constructor:>>>>:");
        }
        public double Volume()
        {
            return (length * width * height);
        }
        ~ChainingConstructor()
        {
            Console.WriteLine("object is destroyed");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("CSE", 1, "limon");
            // Student student1 = new Student("cse");
            var c1 = new ChainingConstructor(12, 12.2, 14);
            Console.WriteLine(c1.Volume());
            // c1 = null;
            // GC.Collect();
            // Console.ReadKey();

        }
    }
}
