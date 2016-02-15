using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sisikaryakan
{
    class Manager : Supervisor
    {
        public int holidayAllowance;
        public int TourStudyAllowance;
        public int healthBenefits;

        public Manager()
        {

        }

        public Manager(string position)
        {
            this.position = position;
        }
    }
}
