using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lets_split
{
    public class Person
    {

        public string Name { get; private set; }
        private Dictionary<Person, double> Debt = new Dictionary<Person, double>();
        public double TotalDebt { get; private set; }

        public Person(string Name)
        {
            this.Name = Name;

        }

        public Dictionary<Person, double> GetDebtList()
        {
            return Debt;
        }

        public void AddToDebt(Person To, double Amount)
        {
            if (Debt.ContainsKey(To))
            {
                Debt[To] += Amount;
            }
            else
            {
                Debt.Add(To, Amount);
            }
        }

        public void RemoveFromDebt(Person From, int Amount)
        {
            if (Debt.ContainsKey(From))
            {
                if (Amount < Debt[From])
                {
                    Debt[From] -= Amount;
                }
                else
                {
                    Debt.Remove(From);
                }
            }
        }

        public void RemoveDebt(Person From)
        {
            if (Debt.ContainsKey(From))
            {
                Debt.Remove(From);
            }
        }

        public enum Relation {FirstOwesSecond, Even, SecondOwesFirst, }

        public static Relation Difference(Person p1, Person p2)
        {
            if (p1.Debt.ContainsKey(p2) && !p2.Debt.ContainsKey(p1))
            {
                return Relation.FirstOwesSecond;
            }
            else if (!p1.Debt.ContainsKey(p2) && p2.Debt.ContainsKey(p1))
            {
                return Relation.SecondOwesFirst;
            }
            else if ((!p1.Debt.ContainsKey(p2) && !p2.Debt.ContainsKey(p1)))
            {
                return Relation.Even;
            }
            else
            {
                if (p1.Debt[p2] > p2.Debt[p1])
                {
                    return Relation.FirstOwesSecond;
                }
                else if (p1.Debt[p2] < p2.Debt[p1])
                {
                    return Relation.SecondOwesFirst;
                }
                else
                {
                    return Relation.Even;
                }
            }
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
