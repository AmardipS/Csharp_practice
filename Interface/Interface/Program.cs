using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// An Interface is an agreement that it guarantees specific functionalities to the Class that inherits
// It does not care how, just what Methods/Functionalities does the Interface includes.
// All Methods and functionalities are defined in Interface but not implemented
// Any class that inherits the Interface that class must implement those methods/functionalities
// A class can be inherited from only a single class but multiple Interfaces
// Interface tells class what it must do, but not how to do it
// Methods in Interface will be automatically Public and can't include any Access Modifier

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Machine1 m1 = new Machine1();
            Machine2 m2 = new Machine2();
            Machine3 m3 = new Machine3();

            m1.Start();
            m1.Stop();
            m2.Start();
            m3.Stop();
            //m2.On();
            //m3.TurnOn();


        }
    }

    // How Interface maintains commonalities among classes
    public class Machine1 : IControls
    {
        public void Start()
        {
            // Some functionality
        }

        public void Stop() {
            // Some functionality
        }
    }

    public class Machine2 : IControls
    {
        public void Start()
        {
            // Some functionality
        }

        public void Stop()
        {
            // Some functionality
        }

        //public void On()
        //{

        //}
    }

    public class Machine3 : IControls
    {
        public void Start()
        {
            // Some functionality
        }

        public void Stop()
        {
            // Some functionality
        }

        //public void TurnOn()
        //{

        //}
    }

    interface IControls
    {
        void Start();
        void Stop();
    }

}
