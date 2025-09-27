using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Advanced
{
    public class DogISP : IWalkISP, IBarkISP
    {
        public void Bark()
        {
            Console.WriteLine("Dog Bark");
        }

        public void Walk()
        {
            Console.WriteLine("Dog Walk");
        }
    }
}
