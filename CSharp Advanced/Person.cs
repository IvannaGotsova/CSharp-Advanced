using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Advanced
{
    public class Person
    {
        public string firstName;
        public string lastName;
        private int age;
        public static string signature = "Person Test";

        //static Person() 
        //{
        //    Console.WriteLine("This is Person static constructor");
        //}
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public int number { get; private set; } = 2;
        public static void StaticClassExample()
        {       
            Console.WriteLine("Static class Example");
        }
    }
}
