using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Overloading
{
    public class Point
    {
        public int X;
        public int Y;

        public Point(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public void Move(int x, int y)
        {
            this.X = x;
            this.Y = y;
            Console.WriteLine("Moved to new location x = {0}, y = {1}", x , y);
        }

        public void Move(Point newLocation)
        {
            // this.X = newLocation.X;
            // this.Y = newLocation.Y;
            
            if (newLocation == null)
                throw new ArgumentNullException("newLocation");
     
            Console.WriteLine("Moved to newLocation Point. ({0}, {1})", X, Y );
            Move(newLocation.X, newLocation.Y);
        }
    }
}
