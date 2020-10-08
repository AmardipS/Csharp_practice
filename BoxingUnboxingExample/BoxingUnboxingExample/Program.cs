using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxingUnboxingExample
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 100;
            int j;

            // Boxing 
            // takes place when the value type varialble is assigned to 
            // a reference type, it needs to be boxed
            object o = x;

            // Unboxing
            // throws an exception "An explicit conversion exists"
            // Compiler can't assign the reference type value to a value type
            // j = o;

            // therefore it needs a CASTING
            // Needs to limit this kind of accessing because it could degrade the performance
            j = (int)o; 

        }
    }
}
