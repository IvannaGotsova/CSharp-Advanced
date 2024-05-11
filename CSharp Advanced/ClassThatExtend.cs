using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Advanced
{
    static class ClassThatExtend
    {
        public static void FourthMethod(this ClassToBeExtended classToBeExtended)
        {
            Console.WriteLine("Fourth method");
        }
        public static void FifthMethod(this ClassToBeExtended classToBeExtended)
        {
            Console.WriteLine("Fifth method");
        }
        public static void SixthMethod(this ClassToBeExtended classToBeExtended)
        {
            Console.WriteLine("Sixth method");
        }
    }
}
