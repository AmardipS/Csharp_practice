using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    class Program
    {
        static void Main(string[] args)
        {
            ProgressReporter p = WriteProgressToConsole;
            p += WriteProgressToFile;
            Util.Hardwork(p);
        }

        static void WriteProgressToFile(int percentComplete)
           => System.IO.File.WriteAllText("progress.txt", percentComplete.ToString());

        static void WriteProgressToConsole(int percentComplete)
        {
            Console.WriteLine(percentComplete);
            Console.ReadLine();
        }



        
    }
}


public delegate void ProgressReporter(int percentComplete);

public class Util
{
    public static void Hardwork(ProgressReporter p)
    {
        for (int i = 0; i < 10; i++)
        {
            p(i * 10);
            System.Threading.Thread.Sleep(100);
        }
    }
}