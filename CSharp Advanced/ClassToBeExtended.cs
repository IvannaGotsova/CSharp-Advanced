using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Advanced
{
    public class ClassToBeExtended
    {
        public void FirstMethod () 
        {
            Console.WriteLine("First method");
        }
        public void SecondMethod()
        {
            Console.WriteLine("Second method");
        }
        public void ThirdMethod()
        {
            Console.WriteLine("Third method");

        }

        public void AddOne(int number)
        {
            Console.WriteLine(number + 1);
        }

        public void AddTwo(int number)
        {
            Console.WriteLine(number + 2);
        }

        public void AddThree(int number)
        {
            Console.WriteLine(number + 3);
        }

        public void AddFour(int number)
        {
            Console.WriteLine(number + 4);
        }

        public void AddFive(int number)
        {
            Console.WriteLine(number + 5);
        }
    }
}
