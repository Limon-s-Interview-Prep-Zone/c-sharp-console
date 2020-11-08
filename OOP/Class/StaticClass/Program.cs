using System;

namespace StaticClass
{

    class StaticDemo
    {
        public static string A_name = "Ankita";
        public static string L_name = "CSharp";
        public static int T_no = 84;

        // Static method of Author 
        public static void details()
        {
            Console.WriteLine("The details of Author is:");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            StaticDemo.details();
            Console.WriteLine("Hello World!");
        }
    }
}
