using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS2PM.inheritance
{
    abstract class BaseEmployee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        internal string Email { get; set; }

        public virtual void Test()
        {
            Console.WriteLine("I am from Base Employee !");
        }
        public abstract decimal CalculateSalary();
    }
}
