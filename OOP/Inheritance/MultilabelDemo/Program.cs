using System;

namespace MultilabelDemo
{
    class Person
    {
        public int Id;
        public string Name;
        public String Gender;
        private int Age;
        public Person(int Id, string Name, string Gender)
        {
            this.Id = Id;
            this.Name = Name;
            this.Gender = Gender;
        }
        public int _Age
        {
            get { return Age; }
            set { Age = value; }
        }
    }
    public interface Show
    {
        public void display();
    }
    class Student : Person, Show
    {
        public string Dept;
        public string Semester;

        public Student(string Dept, string Semester, int Id, string Name, string Gender) : base(Id, Name, Gender)
        {
            this.Dept = Dept;
            this.Semester = Semester;
        }
        public void display()
        {
            Console.WriteLine("Id: {0}\t Name: {1}\t Gender: {2}\t Department: {3}\t Semester: {4}\t Age: {5}", Id, Name, Gender, Dept, Semester, _Age);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("BCSE", "Fall", 1, "Limon", "Male");
            student._Age = 12;
            student.display();
        }
    }
}
//  interface can't have field;
//  ininterface only can have declaration but no implementation