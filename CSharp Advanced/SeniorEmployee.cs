using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Advanced
{
    public class SeniorEmployee
    {
        public decimal Salary
        {
            get { return _salary; }
            set
            {
                var currentSalary = Salary;
                _salary = value;
                if (currentSalary > _salary)
                {
                    OnSalaryIncreased?.Invoke(this, value);
                } 
                else if (currentSalary < _salary)
                {
                    OnSalaryDecreased?.Invoke(this, this._salary);
                }
            }
        }

        private decimal _salary { get; set; }

        public event EventHandler<decimal> OnSalaryIncreased;
        public event EventHandler<decimal> OnSalaryDecreased;
    }
}
