using System;
using System.Collections.Generic;
using System.Text;

/*
             * Create an abstract class called Vehicle
             * The vehicle class shall have three string properties Year, Make, and Model
             * Set the defaults to something generic in the Vehicle class
             * Vehicle shall have an abstract method called DriveAbstract with no implementation
             * Vehicle shall have a virtual method called DriveVirtual with a base implementation.
*/

namespace ConsoleUI
{
    public abstract class Vehicle
    {
        public string Make { get; set; } = "Make"; //             added default values
        public string Model { get; set; } = "Model"; //  removed abstract from strings
        public string Year { get; set; } = "2000 and late"; //fixed from int to string

        public abstract void DriveAbstract();

        public virtual void DriveVirtual()
        {
            Console.WriteLine("Getting on the 10 and never coming back.");
        }

    }
    
}
