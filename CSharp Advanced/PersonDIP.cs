using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Advanced
{
    public class PersonDIP
    {
        IAnimalDIP animalDIP;

        public PersonDIP(IAnimalDIP animalDIP)
        {
            this.animalDIP = animalDIP;
        }

        public void WalkAnimal()
        {
            animalDIP.Walk();
        }
    }
}
