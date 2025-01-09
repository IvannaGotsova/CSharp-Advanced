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

        public static void AddSix(this ClassToBeExtended classToBeExtended, int number)
        {
            Console.WriteLine(number + 6);
        }

        public static void AddSeven(this ClassToBeExtended classToBeExtended, int number)
        {
            Console.WriteLine(number + 7);
        }

        public static void AddEight(this ClassToBeExtended classToBeExtended, int number)
        {
            Console.WriteLine(number + 8);
        }

        public static void AddNine(this ClassToBeExtended classToBeExtended, int number)
        {
            Console.WriteLine(number + 9);
        }

    }
}
