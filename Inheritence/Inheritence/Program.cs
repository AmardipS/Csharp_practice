using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritence
{
    class Program
    {
        static void Main(string[] args)
        {
            Patient p = new Patient();
            Child c = new Child();

            p.Examine("John");

            c.Examine("Arnes");
        }
    }

    class Patient
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public int Weight { get; set; }
        public long SSN { get; set; }

        public void Examine(string pName)
        {
            Console.WriteLine("Examination of " + pName + " complete.");
        }

        public void Billing(long ssn)
        {
            Console.WriteLine("Billing is completed.");
        }
    }

    // Inheritence provides the additional functionalities from main class to derived class
    // Child class is inherited to the Patient class
    // The Child class can utilize the functionalities from the Patient class
    class Child : Patient
    {
        public void Inoculate()
        {
            Console.WriteLine("Child has been inoculated.");
        }
    }
}
    