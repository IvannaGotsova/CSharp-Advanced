using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Advanced
{
    abstract class Animal
    {
        public void AnimalSayHello()
        {
            Console.WriteLine("Hello");
        }
        public abstract void AnimalSayFullHello();
    }
}
