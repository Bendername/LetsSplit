using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lets_split
{
    class Optimizer
    {
        public static Optimizer instance;
        public ListBox.ObjectCollection persons;

        public Optimizer()
        {
            if (instance == null)
            {
                instance = this;
            }
        }

        public void OptimizeBetweenTwoPersons(Person first, Person second)
        {
            Person.Relation relation = Person.Difference(first, second);

            if (relation == Person.Relation.Even)
            {
                first.RemoveDebt(second);
                second.RemoveDebt(first);
            }
            else if (relation == Person.Relation.FirstOwesSecond)
            {

            }
        }
    }
}
