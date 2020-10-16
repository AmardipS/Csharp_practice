using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Threads_Practice
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Program p = new Program();

            Thread t1 = new Thread(func1);
            Thread t2 = new Thread(p.func2);
            Thread t3 = new Thread(func3);
            t1.Start();
            t2.Start();
            t3.Start();

        }

        public static void func1()
        {
            Console.WriteLine("Function 1 Starting...");
            for (int i = 0; i < 30; i++)
            {
                Console.WriteLine("Function1 : {0}", i);
            }
            Console.WriteLine("Function 1 FINISHED.");
        }

        public void func2()
        {
            Console.WriteLine("Function 2 starting...");
            for (int i = 0; i < 30; i++)
            {
                Console.WriteLine("Function2: {0}", i);

                if (i == 25)
                {
                    Console.WriteLine("Thread is going to sleep for 8 secs.");
                    Thread.Sleep(8000);
                }
            }
            Console.WriteLine("Function 2 FINISHED.");
        }

        public static void func3()
        {
            Console.WriteLine("Function 3 starting...");
            for (int i = 0; i < 30; i++)
            {
                Console.WriteLine("Function3: {0}", i);
            }

            Console.WriteLine("Function 3 FINISHED.");
        }

    }
}
