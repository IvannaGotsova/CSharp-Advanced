using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Advanced
{
    public class PersonSRPAge
    {
        public int BirthDate(PersonSRP personSRP)
        {
            DateTime todayDate = DateTime.Today;
            DateTime birthDate = todayDate.AddYears(-personSRP.age);
            return birthDate.Year;
        }
    }
}
