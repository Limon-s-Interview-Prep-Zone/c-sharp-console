using System;

namespace AccessSpecifier
{
    public class Customer
    {
        private int _id;
        public string Name;
        protected string CardNumber = "107.108.1245.25";
        public int Id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }
    }
    class CustomerCard : Customer
    {
        public void display()
        {
            Console.WriteLine(CardNumber);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            CustomerCard ct = new CustomerCard();
            customer.Id = 45;
            customer.Name = "limon";
            Console.WriteLine("Customer Id:{0} Name:{1}", customer.Id, customer.Name);
            ct.display();
            // customer._id=12;
        }
    }
}
