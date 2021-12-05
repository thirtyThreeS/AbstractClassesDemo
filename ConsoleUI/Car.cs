using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    class Car : Vehicle
    {
        public bool hasTrunk { get; set; }


        public override void DriveAbstract()
        {
            Console.WriteLine($"Hold on to your pants sonny.. This {Model} is going to put you in the back seat.");
        }
    }
}
