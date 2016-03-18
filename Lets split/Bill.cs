using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lets_split
{
    public class Bill
    {
        public Person Buyer { get; private set; }
        public Dictionary<string, double> distribution = new Dictionary<string, double>();
        public double TotalAmount {
            get
            {
                double amount = 0;
                foreach (string p in distribution.Keys)
                {
                    amount += distribution[p];
                }
                return amount;
            }
        }

        public Bill(Person Buyer)
        {
            this.Buyer = Buyer;
        }
    }
}
