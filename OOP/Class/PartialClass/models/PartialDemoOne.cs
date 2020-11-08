using System;

namespace models.PartialDemo
{
    public partial class PartialEmployee
    {

        public PartialEmployee()
        {
            Console.WriteLine("PartialEmployee Constructor");
        }
        public void DisplayFullName()
        {
            Console.WriteLine(@"Full Name is :  {0} {1}", _firstName, _lastName);
        }
        public void DisplayEmployeeDetails()
        {
            Console.WriteLine("Employee Details : ");
            Console.WriteLine(@"First Name : {0}", _firstName);
            Console.WriteLine(@"Last Name : {0}", _lastName);
            Console.WriteLine(@"Gender : {0}", _gender);
            Console.WriteLine(@"Salary : {0}", _salary);
            PartialMethod();
        }
    }
}