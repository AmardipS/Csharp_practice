using System;
using ProjectA.GroupA;
using ProjectA.GroupB;

// Namespace is a container where classes and methods 
// are defined, 
namespace Namespace
{
    class Program
    {
        static void Main(string[] args)
        {
            // ProjectA.GroupA.ClassA.print();
            // is the full description of the print() method
            // can be make short defining the Namespace 'using ProjectA.GroupA' on the top
            ClassA.print();
            ClassB.print();
        }
    }
}

namespace ProjectA
{
    namespace GroupA
    {
        class ClassA
        {
            public static void print()
            {
                Console.WriteLine("This print is from ClassA.");
            }
        }
    }

    namespace GroupB
    {
        class ClassB
        {
            public static void print()
            {
                Console.WriteLine("This print is from ClassB.");
            }
        }
 
    }
}
