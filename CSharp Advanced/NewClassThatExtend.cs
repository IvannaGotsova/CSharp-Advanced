using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Advanced
{
    static class NewClassThatExtend
    {
        public static void Print(this ClassToBeExtended classToBeExtended)
        {
            Console.WriteLine("Method that prints...");
        }

    }
}
