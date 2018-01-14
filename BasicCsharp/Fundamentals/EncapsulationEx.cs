// import statements for external library
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace - package

namespace Fundamentals
{
    public class Vehicle
    {
        private int NoOfWheels { get; set; }  // int 32bit
        private string Model { get; set; }   // string 16bit
        private string Year { get; set; }

        // default constructor - a constructor that takes 0 arguments
        // provided by compiler if their is no other constructor defined
        //public Vehicle()
        //{

        //}

        // if we remove defaul constructor above will get belwo errors.
       //'Fundamentals.Vehicle' does not contain a constructor that takes 0 arguments

       
        // I want to call custom constructor with parameters with their types.
        public Vehicle(int noOfWheel, string model, string year)
        {
            this.Model = model;
        }

        // so private members or methods can only be accessed with in class.
        public void Display(string model)
        {
            this.Model = model;

            // display vehcile information
            System.Console.Write("Vehicle model - {0}", this.Model);
        }
    }
}
