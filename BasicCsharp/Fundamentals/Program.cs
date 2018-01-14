using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentals
{
    class Program
    {
        static void Main(string[] args)
        {

           //Vehicle v = new Vehicle();  //'Fundamentals.Vehicle' does not contain a constructor that takes 0 arguments

           // Error	2	A local variable named 'v' is already defined in this scope	

           Vehicle v = new Vehicle(4,"i10","2010");  // object created and memory allocated for 3 variables


            // display information by calling display method
            //Error	1	'Fundamentals.Vehicle.Display()' is inaccessible due to its protection level means method is private not public

            v.Display("i20");
            //v.NoOfWheels = 2;

            System.Console.Read();
        }
    }
}
