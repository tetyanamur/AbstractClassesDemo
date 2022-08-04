using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    public abstract class Vechile
    {

        public int Year { get; set; } = 1;
        public string Make { get; set; } = "Default make";

        public string Model { get; set; } = "Default model";

        public abstract void DriveAbstract();
        public virtual void DriveVirtual()
        {
            Console.WriteLine($"This{GetType().Name} is virtually in drive");

        }
    }
}

 
