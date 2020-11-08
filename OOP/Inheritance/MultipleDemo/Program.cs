using System;

namespace MultipleDemo
{
    public interface A
    {
        public void showName();
    }
    public interface B
    {
        public void DispplayDetails();
    }
    class Limon : A, B
    {
        public virtual void showName()
        {
            Console.WriteLine("Limon Class- Implement interface A");
        }
        public void DispplayDetails()
        {
            Console.WriteLine("Limon Class- Implement interface B");
        }
    }
    class Likhon : Limon
    {
        public override void showName()
        {
            Console.WriteLine("Likon Class- Inherit limon class");
        }
    }
    class Common : Likhon
    {
        public override void showName()
        {
            Console.WriteLine("Common Class");
            Console.WriteLine("***Calling base class Method***");
            base.DispplayDetails();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Limon limon = new Limon();
            limon.showName();
            Likhon likhon = new Likhon();
            likhon.showName();
            likhon.DispplayDetails();
            Common common = new Common();
            common.showName();
        }
    }
}
