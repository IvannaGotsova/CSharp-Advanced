using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Advanced
{
    public class LooseCouplingClass : ILooseCoupling
    {
        public void LooseCoupling(string looseCoupling)
        {
            Console.WriteLine(looseCoupling);
        }
    }
}
