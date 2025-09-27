using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Advanced
{
    public class CatISP : IMeowISP, IWalkISP
    {
        public void Meow()
        {
            Console.WriteLine("Cat Meow");
        }

        public void Walk()
        {
            Console.WriteLine("Cat Walk");
        }
    }
}
