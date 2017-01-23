using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week4._1
{
    class Cat:Animal
    {
        //fields
        private string breed;
        private string furLength;

        private bool declawed;

        //constructor                                              calling the base(Animal) class constructor
        public Cat(string breed, string furLength, bool declawed): base(4, 3, 3, "tan")
        {
            this.breed = breed;
            this.furLength = furLength;
            this.declawed = declawed;
        }

    }
}
