using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS2PM
{
    class Employee
    {
        public string Id;
        public string Name;
        public decimal Salary;
        public string Dept;

        public Employee()
        {
            Console.WriteLine("I am paramterless constructor !");
        }
        public Employee(string id,string name,decimal salary,string dept)
        {
            Console.WriteLine("I am paramterise constructor !");
            this.Id = id;
            this.Name = name;
            this.Salary = salary;
            this.Dept = dept;
        }

        public Employee(Employee em)
        {
            this.Id = em.Id;
            this.Name = em.Name;
            this.Salary = em.Salary;
            this.Dept = em.Dept;
        }
        public decimal GetPerMonthSalary()
        {
            return this.Salary / 12;
        }

        ~Employee() { }

    }
}
