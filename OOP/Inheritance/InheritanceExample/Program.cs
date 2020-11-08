using System;

namespace InheritanceExample
{
    class Peroson
    {
        int Id;
        string Name;
        string Address;
        string Phone;
        public void getPersonDatils()
        {
            Console.WriteLine("ENTER PERSON DETAILS:");
            Console.WriteLine("ENTER Person ID");
            Id = int.Parse(Console.ReadLine());
            Console.WriteLine("ENTER PERSON NAME");
            Name = Console.ReadLine();
            Console.WriteLine("ENTER Person Address");
            Address = Console.ReadLine();
            Console.WriteLine("ENTER Person Contact Number");
            Phone = Console.ReadLine();
        }
        public void ShowDeatils()
        {
            Console.WriteLine("Person ID IS : " + Id);
            Console.WriteLine("Person NAME IS : " + Name);
            Console.WriteLine("Person ADDRESS IS : " + Address);
            Console.WriteLine("Person Phone IS : " + Phone);
        }
    }
    class Student : Peroson
    {
        string Status;
        string Fees;
        string Marks;
        public Student(string Status, string Fees, string Marks)
        {
            this.Status = Status;
            this.Fees = Fees;
            this.Marks = Marks;
        }
        public void showStudents()
        {
            Console.WriteLine("Status:{0}\t Fees:{1}\t Marks:{2}", Status, Fees, Marks);
        }
    }
    class Teacher : Peroson
    {
        string Room;
        string TotalClass;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Peroson peroson = new Peroson();
            Student student = new Student("BCSE", "50", "A");
            peroson.getPersonDatils();
            peroson.ShowDeatils();
            student.showStudents();
            Console.WriteLine("Example of inheritance");
        }
    }
}
