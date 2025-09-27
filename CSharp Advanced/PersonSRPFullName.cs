using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Advanced
{
    public class PersonSRPFullName
    {
        public string FullName(PersonSRP personSRP)
        {
            return personSRP.firstName + " " + personSRP.lastName;
        }
    }
}
