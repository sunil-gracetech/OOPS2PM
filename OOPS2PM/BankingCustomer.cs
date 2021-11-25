using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS2PM
{
    class BankingCustomer
    {
        public string AcNo { get; }
        public string Name;
        private decimal _Amount;

        public BankingCustomer(string acno,string name,decimal amount)
        {
            this.AcNo = acno;
            this.Name = name;
            this._Amount = amount;


        }
        public decimal Amount
        {
            get{ return this._Amount; }
            set
            {
                if (value > 1000)
                {
                    this._Amount = value;
                }
            }
        }
    }
}
