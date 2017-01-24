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

        //constructor                                             calling the base(Animal) class constructor
        // 4 arguments 
        public Cat(string breed, string furLength, bool declawed, string color): base(4, 3, 3)
        {
            this.breed = breed;
            this.furLength = furLength;
            this.declawed = declawed;
            this.color = color;
            isGoodToEat = false;
        }

        //method
        
        public void Speak()
        {
            Console.WriteLine("Meow!");
        }
        public override void PrintAnimalInfo()
        {
            Console.WriteLine("I am a cat. ");
            base.PrintAnimalInfo();
            Console.WriteLine("Breed is: " + breed + " cat");
            Console.WriteLine("furLength is: " + furLength);
            Console.WriteLine("Declawed: " + declawed);
        }
    }
}
