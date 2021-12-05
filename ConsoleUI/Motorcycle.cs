using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    class Motorcycle : Vehicle
    {
        public bool hasSideCart { get; set; }
       

        public override void DriveAbstract()
        {
            Console.WriteLine("Putt Putt Poof");
        }

        public override void DriveVirtual()
        {
            Console.WriteLine($"Taking the 45 to the 10 and never getting off! Nothing like riding the brand-new {Model}");
        }
    }
}
