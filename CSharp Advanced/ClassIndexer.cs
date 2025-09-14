using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Advanced
{
    public class ClassIndexer
    {
        private int[] numbers = new int[11];

        public int this[int i]
        {
            get { return numbers[i]; }
            set { numbers[i] = value; }
        }

        public int Length
        {
            get { return numbers.Length; }
        }
    }
}
