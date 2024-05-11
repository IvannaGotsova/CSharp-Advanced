using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Advanced
{
     class Dog : Animal
    {
        public override void AnimalSayFullHello()
        {
            Console.WriteLine("Dog say \"Hello\"");
        }
    }
}
