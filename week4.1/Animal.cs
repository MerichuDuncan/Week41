using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week4._1
{
    class Animal
    {
        //fields
        private int legs;
        private int size;
        private int weight;

        protected string color;

        protected bool isGoodToEat;
       

        //default constructor ( Needed if you will add another sub-class )
        public Animal()
        {

        }

         //default constructor
            public Animal( int legs, string color)
        {
            this.legs = legs;
            this.color = color;
        }

        public Animal( int legs, int size, int weight)
        {
            this.legs = legs;
            this.size = size;
            this.weight = weight;

        }
        //another constructor
        public Animal( int legs, int size, int weight, string color )

        {
            this.legs = legs;
            this.size = size;
            this.weight = weight;
            this.color = color;

        }

        //method
        public void PrintAnimalInfo()
        {
            Console.WriteLine("This animal has : " + legs + " number of legs");
            Console.WriteLine("It's size is : " + size);
            Console.WriteLine("It's weighs is : " + weight);
            Console.WriteLine("And it's color is " + color);
        }
        protected void WhoAmI()
        {
            Console.WriteLine("I am an animal");
        }
    }

}
