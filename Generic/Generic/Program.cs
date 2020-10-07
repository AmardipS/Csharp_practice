using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Generic
{
    class Program
    {
        static void Main(string[] args)
        {
            // Non generic ArrayList does not define the object type
            ArrayList list1 = new ArrayList();
            list1.Add(4);
            list1.Add(8);
            list1.Add(7);
            // Non generic List doesn't show compilling error
            // But throws exception at runtime
            // list1.Add("Hello");

            Console.WriteLine("Non-generic List results...");
            foreach(int x in list1)
            {
                Console.WriteLine(x);
            }

            // Generic List
            List<int> list2 = new List<int>();
            list2.Add(6);
            list2.Add(1);
            list2.Add(9);
            // Throw error and don't let to compile
            // list2.Add("Hello");

            Console.WriteLine("Generic List results...");
            foreach (var item in list2)
            {
                Console.WriteLine(item);
            }


        }
    }
}
