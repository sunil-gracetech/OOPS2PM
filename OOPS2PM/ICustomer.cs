using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS2PM
{
   public interface ICustomer
    {
        List<CustomerModel> GetCustomers();
        void Create(CustomerModel model);
        void Update(CustomerModel model);
        void Delete(int id);

    }
}
