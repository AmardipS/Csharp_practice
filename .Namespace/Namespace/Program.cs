using System;
using ProjectA.GroupA;
using ProjectA.GroupB;

namespace Namespace
{
    class Program
    {
        static void Main(string[] args)
        {
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
