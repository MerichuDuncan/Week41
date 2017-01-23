using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week4._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal animal1 = new Animal(2, "Tan\n\n");
            Animal animal2 = new Animal(6, 1, 1, "\n\n");
        


            animal1.PrintAnimalInfo();
            animal2.PrintAnimalInfo();

            Cat cat1 = new Cat("Grumpy", "Short", false);
            cat1.PrintAnimalInfo();
        }
    }
}
