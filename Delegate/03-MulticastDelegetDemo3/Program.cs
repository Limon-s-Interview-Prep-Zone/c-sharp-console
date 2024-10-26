using System;

namespace MulticastDelegetDemo3
{
    public delegate void MathDelegate(int a, int b);
    class MulticastDemo
    {
        public static void Add(int x, int y)
        {
            Console.WriteLine("THE SUM IS : " + (x + y));
        }
        public static void Sub(int x, int y)
        {
            Console.WriteLine("THE SUB IS : " + (x - y));
        }
        public void Mul(int x, int y)
        {
            Console.WriteLine("THE MUL IS : " + (x * y));
        }
        public void Div(int x, int y)
        {
            Console.WriteLine("THE DIV IS : " + (x / y));
        }
    }

    public delegate int DelegateReturn();
    class DelegateReturnDemo
    {
        public static int MethodOne()
        {
            return 1;
        }
        // This method returns two
        public static int MethodTwo()
        {
            return 2;
        }
    }
    public delegate void DelegateOut(out int a);
    public class DelegateOutDemo
    {
        public static void MethodOne(out int Number)
        {
            Number = 1;
        }
        // This method sets ouput parameter Number to 2
        public static void MethodTwo(out int Number)
        {
            Number = 2;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MulticastDemo md = new MulticastDemo();
            MathDelegate dadd = new MathDelegate(MulticastDemo.Add);
            MathDelegate dsub = new MathDelegate(MulticastDemo.Sub);
            MathDelegate dmul = new MathDelegate(md.Mul);
            MathDelegate ddiv = new MathDelegate(md.Div);
            // chaining all delegate
            MathDelegate rootd = dadd + dsub + dmul + ddiv;
            rootd = rootd - dsub - dmul - ddiv;
            rootd(12, 12);
            //  earlier path
            dsub(12, 10);
            dmul.Invoke(10, 10);

            // delegate return type
            DelegateReturn dr = new DelegateReturn(DelegateReturnDemo.MethodOne);
            dr = dr + DelegateReturnDemo.MethodTwo;
            int valueReturn = dr();
            Console.WriteLine($"Delegate Return for method Two: {DelegateReturnDemo.MethodOne()}");
            Console.WriteLine($"Delegate Return for method Two: {DelegateReturnDemo.MethodTwo()}");
            //  delegate out example
            DelegateOut delegateOut = new DelegateOut(DelegateOutDemo.MethodOne);
            delegateOut = delegateOut + DelegateOutDemo.MethodTwo;
            int returnOut = 0;
            delegateOut(out returnOut);
            Console.WriteLine($"Delegate OUT for method Two: { returnOut}");
            delegateOut -= DelegateOutDemo.MethodTwo;
            delegateOut(out returnOut);
            Console.WriteLine($"Delegate OUT for method One: { returnOut}");
        }
    }
}
