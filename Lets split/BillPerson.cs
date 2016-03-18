using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lets_split
{
    public class BillPerson : Person
    {
        public bool participating = false;
        public int weight = 1;
        public BillPerson(Person P) : base(P.Name)
        {
        }
    }
}
