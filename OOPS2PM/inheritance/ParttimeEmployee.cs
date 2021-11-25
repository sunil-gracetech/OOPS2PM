using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS2PM.inheritance
{
    class ParttimeEmployee:BaseEmployee
    {
        public int WorkingHour { get; set; }
        public decimal PerHourSalary { get; set; }

        public override decimal CalculateSalary()
        {
            return PerHourSalary * WorkingHour;
        }
    }
}
