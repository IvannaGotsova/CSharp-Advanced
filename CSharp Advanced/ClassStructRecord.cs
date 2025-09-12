using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Advanced
{
    public class ClassStructRecord
    {
        public string example;
        public int number;

        public ClassStructRecord()
        {
      
            example = "ExampleClass";
            number = 0;
        }
    }


    public struct Struct
    {
        public string example;
        public int number;
        public Struct()
        {
            example = "ExampleStruct";
            number = 1;
        }
    }

    public record Record
    {
        public string example;
        public int number;
        public Record()
        {
            example = "ExampleRecord";
            number = 2;
        }
    }
}
