using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Advanced
{
    public class JuniorEmployee
    {
        public int Experience
        {
            get { return _experience; }
            set
            {
                var currentExperience = Experience;
                _experience = value;
                if (currentExperience > _experience)
                {
                    OnExperienceIncreased?.Invoke(this, value);
                }
                else if (currentExperience < _experience)
                {
                    OnExperienceDecreased?.Invoke(this, value);
                }
            }
        }

        private int _experience { get; set; }

        public event EventHandler<int> OnExperienceIncreased;
        public event EventHandler<int> OnExperienceDecreased;
    }
}
