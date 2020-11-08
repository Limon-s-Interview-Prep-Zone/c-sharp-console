using System;
using models.PartialDemo;
namespace PartialClass
{
    class Program
    {

        static void Main(string[] args)
        {
            PartialEmployee p = new PartialEmployee();
            p.FirstName = "Md Malek";
            p.LastName = "Limon";
            p.Gender = "Male";
            p.DisplayEmployeeDetails();
            p.DisplayFullName();
        }
    }
}

// partial class specify with partial keyword.
// When we have large project to split different parts to work simultenously.

// partialclass have same parent class
// partial class can implement different interface.