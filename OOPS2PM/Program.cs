using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOPS2PM.inheritance;
namespace OOPS2PM
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Employee emp1 = new Employee("emp002","mohit verma",30000,"HR");
            Employee cp = new Employee(emp1);

           // Employee emp1 = new Employee();
            //emp1.Id = "emp001";
            //emp1.Name = "rajesh";
            //emp1.Salary = 2000;
            //emp1.Dept = "IT";

            Console.WriteLine("Employee Id: "+emp1.Id);
            Console.WriteLine("Employee Name: "+emp1.Name);
            Console.WriteLine("Employee Salary: "+emp1.Salary);
            Console.WriteLine("Employee Dept: "+emp1.Dept);
            Console.WriteLine("Employee Monthaly Salary : "+emp1.GetPerMonthSalary());
           
            emp1.Salary -= 50000;
            emp1.Name = "deepak";

            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Employee Id: " + emp1.Id);
            Console.WriteLine("Employee Name: " + emp1.Name);
            Console.WriteLine("Employee Salary: " + emp1.Salary);
            Console.WriteLine("Employee Dept: " + emp1.Dept);
            Console.WriteLine("Employee Monthaly Salary : " + emp1.GetPerMonthSalary());



            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Employee Id: " + cp.Id);
            Console.WriteLine("Employee Name: " + cp.Name);
            Console.WriteLine("Employee Salary: " + cp.Salary);
            Console.WriteLine("Employee Dept: " + cp.Dept);
            Console.WriteLine("Employee Monthaly Salary : " + cp.GetPerMonthSalary());
            */


            //BankingCustomer customer = new BankingCustomer("ICCI00121", "Rajesh", 15000);
            //Console.WriteLine("Customer Account Number: "+customer.AcNo);
            //Console.WriteLine("Customer Name: "+customer.Name);
            //Console.WriteLine("Customer Amount: "+customer.Amount);

            ////customer.AcNo = "dgfdzfg";
            //customer.Amount -= 13000;
            //Console.WriteLine("-----------------customr----------------");
            //Console.WriteLine("Customer Account Number: " + customer.AcNo);
            //Console.WriteLine("Customer Name: " + customer.Name);
            //Console.WriteLine("Customer Amount: " + customer.Amount);

            //MyStatic.fname = "rajeev";
            //MyStatic.lname = "sharma";
            //string f = MyStatic.FullName();
            //Console.WriteLine(f);

            /*
            MyStatic obj1 = new MyStatic();
            MyStatic obj2 = new MyStatic();
            MyStatic obj3 = new MyStatic();
            Console.WriteLine("Count: "+MyStatic.count);
           */

            FulltimeEmployee fulltime = new FulltimeEmployee();

            fulltime.Test();

            //ParttimeEmployee parttime = new ParttimeEmployee();

            //var res=MyStatic.Addition(50.32, 40.34);
            //Console.WriteLine(res);

            Console.Read();
        }
    }
}
