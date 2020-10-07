using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overriding
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer C1 = new Customer();
            C1.firstName = "Simon";
            C1.lastName = "Tan";
            C1.age = 29;

            // Both o/p is true since both the value and reference are equal
            // Since both C1 and C2 are pointing to the same reference address
            // Customer C2 = C1;

            // Both o/p are false since both C1 & C2 have different 
            // reference address, they are different objecsts now
            Customer C2 = new Customer();
            C2.firstName = "Simon";
            C2.lastName = "Tan";
            C2.age = 29;
            Console.WriteLine(C1 == C2);
            Console.WriteLine(C1.Equals(C2));
            
            /*
             * From Customer.cs 
             * 
            Customer c = new Customer();
            Male m = new Male();

            c.Print();
            m.Print();
            */
        }
    }

    class Customer
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public int age { get; set; }


        // Overriding Equals method for value checking
        public override bool Equals(object obj)
        {
            if(obj == null)
            {
                return false;
            }
            if(!(obj is Customer))
            {
                return false;
            }

            return this.firstName == ((Customer)obj).firstName &&
                this.lastName == ((Customer)obj).lastName &&
                this.age == ((Customer)obj).age;

        }
    }
}
