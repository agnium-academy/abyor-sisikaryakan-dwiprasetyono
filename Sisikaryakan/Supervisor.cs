using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sisikaryakan
{
    class Supervisor : Staff
    {
        public int lodgingAllowance;
        public int internetAllowance;

        public Supervisor()
        {

        }

        public Supervisor (string position)
        {
            this.position = position;
        }
    }
}
