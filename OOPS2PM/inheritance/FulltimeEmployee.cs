using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS2PM.inheritance
{
    class FulltimeEmployee:BaseEmployee
    {
        public decimal AnualSalary { get; set; }

        public override decimal CalculateSalary()
        {
            return this.AnualSalary/12;
        }

        public new void Test()
        {
            Console.WriteLine("I am from Fulltime Employee !");
        }
    }
}
