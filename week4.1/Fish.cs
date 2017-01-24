using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week4._1
{
    class Fish : Animal
    {
        //fields
        private int fins;

        private bool scales;
        private bool teeth;
        private string waterType;


        //default constructor
        public Fish(int fins, bool scales, bool teeth, string waterType) : base(0, "silver")
        {
            this.fins = fins;
            this.scales = scales;
            this.teeth = teeth;
            this.waterType = waterType;
        }

        public void Swim ()
        {
            Console.WriteLine("Just keep swimming, just keep swimming...");
        }

    }
}
