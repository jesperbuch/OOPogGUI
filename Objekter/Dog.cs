using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objekter
{
    class Dog : Animal
    {
        public override void AnimalSound()
        {
            // The body of animalSound() is provided here
            Console.WriteLine("The dog says: wuf wuf");
        }

    }
}
