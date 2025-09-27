using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Advanced
{
    public class DogOCPBarkThree : IDogOCP
    {
        public string Behavior(DogOCP dogOCP)
        {
            return "Bark Bark Bark";
        }
    }
}
