using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod2_Lab1
{
    class TechnicalEmployee : Employee
    {

        public TechnicalEmployee(String name) : base(name, 75000)
        {

        }

        public int successfulCheckIns = 5;

        public override string employeeStatus()
        {
            return this.toString() + "has " + this.successfulCheckIns + " successful check ins";
        }
    }
}
