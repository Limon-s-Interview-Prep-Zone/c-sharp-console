using System;
using System.Runtime.Serialization;
using System.Threading;

namespace PracticeConstructor
{
    // declare delegate with same signature
    public delegate void AddDelegate(int a, int b);
    public delegate string GreetingsDelegate(string c);
    public delegate void Ractangle(double a, double b);
    class Program
    {
        public void GetArea(double Width, double Height)
        {
            Console.WriteLine(@"Area is {0}", (Width * Height));
        }
        public static void GetPerimeter(double Width, double Height)
        {
            Console.WriteLine(@"Perimeter is {0}", (2 * (Width + Height)));
        }

        public void Add(int x, int y)
        {
            Console.WriteLine(@"The Sum of {0} and {1}, is {2} ", x, y, (x + y));
        }
        //Static Method
        public static string Greetings(string name)
        {
            return "Hello @" + name;
        }
        static void Main(string[] args)
        {
            Program obj = new Program();
            //AddDelegate ad = new AddDelegate(obj.Add);
            //GreetingsDelegate gd = new GreetingsDelegate(Program.Greetings);
            //ad(100, 50);
            //ad.Invoke(10,12);
            //ad.Invoke(100, 120);
            //// string GreetingsMessage = gd.Invoke("Pranaya");
            //Console.WriteLine(gd.Invoke("limon"));
            Ractangle ract = new Ractangle(obj.GetArea);
            ract += GetPerimeter;
            ract.Invoke(12, 12);
            ract-=GetPerimeter;
            Console.ReadKey();
        }

    }

}
