using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Sometimes you'd like to add a particular functionality to a class that already exists.
// Extension Methods provide a way to do this
    // Without creating new derived type (class)
    // without recompiling
    // without modifying the original type (class)

namespace Extension_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            string x = "Hello";
            string y = "hello";

            Console.WriteLine(StringCap.IsCap(x));
            Console.WriteLine(StringCap.IsCap(y));

            Console.WriteLine(x + " is capitalized? " + x.IsCap());
            Console.WriteLine(y + " is capitalized? " + y.IsCap());
            
        }
    }

    // Extension method is declaired in a non-generic, non-nested, static class
    // where before first parameter of Extension method there must be 'this' keyword
    public static class StringCap
    {
        public static bool IsCap(this string s)
        {
            if (string.IsNullOrEmpty(s)) return false;
            return char.IsUpper(s[0]);
        }
    }
}
