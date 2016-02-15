using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sisikaryakan
{
    class Staff : Employee
    {
        public int basicSalary;
        public int employeeBenefits;
        public int transportAllowance;

        public Staff()
        {

        }

        public Staff(string position)
        {
            this.position = position;
        }
    }
}