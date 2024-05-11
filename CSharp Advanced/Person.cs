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

        public int Age
        {
            get { return age; }
            set { age = value; }
        }
    }
}
