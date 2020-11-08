using System;

namespace ConstructorDemo
{
    class Student
    {
        public int a, b, c, d;
        public string name = "limon";
        private float width;
        static int count;
        public static int result = 12;
        public Student()
        {
            Console.WriteLine("Default constructor");

        }
        // parametrize constructor
        public Student(int a, int b)
        {
            this.a = a;
            this.b = b;
            Console.WriteLine("Parameterize constructor:a={0} b={1}", a, b);
        }
        // copy constructor
        public Student(Student copy, string Name)
        {
            c = copy.a;
            d = copy.b;
            name = Name;

        }

        // static constructor- can not overlaoding.because it does have parameter.
        static Student()
        {
            count = 100;
            Console.WriteLine("Static constructor called value:" + count);
        }
        public void display()
        {
            Console.WriteLine("Copy constructor:c={0} d={1}, name:{2}\n Count:{3}", this.c, this.d, name, count);
            count++;
            Console.WriteLine("COUNT:" + count);
        }


        // static variable
        public int i = 5;
        public void test()
        {
            i = i + 5;
            Console.WriteLine("STATIC_VARIABLE:" + i);
            ++i;
            Console.WriteLine("STATIC_VARIABLE:" + i);
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            // default
            Student student = new Student();
            Student student2 = new Student(10, 12);
            Student st2 = new Student(student2, "Limon sarker");
            st2.display();
            student.test();
            st2.test();
        }
    }
}
/* Constuctor -type */
// Default constructor> If we don't explicitely define a constructor. then the class will create a default constructor.
// Parameterize constructor: 
// Copy constructor: This takes parameter as class type.Used to one object data to another object.initialize a object with the value of another object
// Static constructor: can have in one value in life time. But if we static vlue initialize in non-static constructor it will loose its static natures. 
// Private Constructor: can access only the accessible with in this class.