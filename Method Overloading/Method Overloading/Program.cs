using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var point = new Point(10, 20);

                // Move method overload with two different parameter types
                // Point object parameter
                point.Move(new Point(40,50));

                // Two integer x and y paramter
                point.Move(30, 40);
            }
            catch (Exception)
            {
                Console.WriteLine("An unexpected error occured.");
            }
        }
    }
}
