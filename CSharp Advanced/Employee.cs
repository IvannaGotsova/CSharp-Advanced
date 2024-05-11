using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Advanced
{
    public class Employee<T>
    {

        public void GetFullName(string firstName, string lastName)
        {
            Console.WriteLine($"{firstName} {lastName}");
        }
        public void GetFullInfo(string firstName, string lastName, int age)
        {
            Console.WriteLine($"{firstName} {lastName}, {age} years old.");
        }
        public void GetGreeting(string firstName, string lastName)
        {
            Console.WriteLine($"Hello from {firstName} {lastName}");
        }
        public void GetBonus(int experience, double salary)
        {
            double bonus = experience * (salary * 0.1);
            Console.WriteLine(bonus);
        }
    }
}
