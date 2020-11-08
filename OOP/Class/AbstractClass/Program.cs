using System;

namespace AbstractClass
{
    public class ParentClass
    {
        public double rate;
        public ParentClass(double rate = 5.5)
        {
            this.rate = rate;
            Console.WriteLine("Parent class Constructor: RATE:" + rate);
        }
    }
    public abstract class AbstractClass : ParentClass
    {
        public void calculation(int units)
        {
            Console.Write("BILL AMOUNT FOR " + units + " UNITS is: Rs.");
            Console.WriteLine(rate * units);
        }
        public AbstractClass()
        {
            Console.WriteLine("Abstract class contructor: RATE_ABS:" + rate);
        }
        // public abstract void calculate(double x);
    }
    class Sub1 : AbstractClass
    {
        // public override void calculate(double x)
        // {
        //     Console.WriteLine("SQUARE ROOT IS " + Math.Sqrt(x));
        // }
    }
    public class Sub2 : AbstractClass
    {
        // public override void calculate(double x)
        // {
        //     Console.WriteLine("SQUARE is :" + (x * x));
        // }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ParentClass parentClass = new ParentClass(5.5);
            Sub2 sub2 = new Sub2();
            // sub2.calculate(12.2);
            sub2.calculation(5);

            Console.WriteLine("");
        }
    }
}

/* Note */
// Abstract class:
// Does not conatin constructor with parameter
// Abstract method: does not contain body. Abstract method can be conatain only abstarct class
//  abstract class can have base class