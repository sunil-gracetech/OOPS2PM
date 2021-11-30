using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS2PM
{
    class Customer : ICustomer
    {
        private List<CustomerModel> customers;
        public Customer()
        {
            customers = new List<CustomerModel>()
            {
                new CustomerModel(){Id=1,Name="deepak",Gender="male"},
                new CustomerModel(){Id=2,Name="amit",Gender="male"},
                new CustomerModel(){Id=3,Name="sumitra",Gender="female"},
            };
            
        }

        public void Create(CustomerModel model)
        {
            customers.Add(model);
        }

        public void Delete(int id)
        {
            var cust = customers.SingleOrDefault(e => e.Id == id);
            if (cust!=null)
            {
                customers.Remove(cust);
            }
            else
            {
                Console.WriteLine("Customer with ID {0} not found",id);
            }
        }

        public List<CustomerModel> GetCustomers()
        {
            return customers.ToList();
        }

        public void Update(CustomerModel model)
        {
           // customers.re
        }
    }
}
