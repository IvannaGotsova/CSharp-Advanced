using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Advanced
{
    public class DependencyInjectionClass : IDependencyInjection
    {
        public void DependencyInjection(string dependencyInjection)
        {
            Console.WriteLine(dependencyInjection);
        }
    }
}
