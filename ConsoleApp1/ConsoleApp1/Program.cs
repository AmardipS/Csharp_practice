using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace ConsoleApp1
{
    class Program
    {

        // Incapsulation : Modularity
        // Inheritence : Code reusability
        // Polymorphism : Extendability
        public static void Main()
        {
            Console.WriteLine("Hello");
        }

        AesCryptoServiceProvider AESCrypto = new AesCryptoServiceProvider();
    }

    
    
    // STRUCT ########################################################################
    //public struct point
    //{
    //    int x;
    //    int y;
    //    // Struct doesn't allowed initialized field
    //    //int z = 0;

    //    // Struct doesn't allow parameterless constructor
    //    //public point() { }

    //    // Struct doesn't allow missing parameter initialization i.e. y
    //    // public point(int x = 0) { this.x = x; }

    //    public point(int x = 1, int y = 0) { this.x = x; this.y = y; }

    //}
}
