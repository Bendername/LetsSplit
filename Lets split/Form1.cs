using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lets_split
{
    public partial class Form1 : Form
    {
        public static Form1 instance;
        public ListBox.ObjectCollection persons;
        public List<Bill> bills = new List<Bill>();

        public Form1()
        {
            if (instance == null)
            {
                instance = this;
            }
            InitializeComponent();
            persons = new ListBox.ObjectCollection(personList);
        }

        public void AddBill(Bill bill)
        {
            foreach (string bP in bill.distribution.Keys)
            {
                foreach (Person p in persons)
                {
                    if (bP == p.Name)
                    {
                        p.AddToDebt(bill.Buyer, bill.distribution[bP]);
                    }
                }
            }
        }

        private void add_person_Click(object sender, EventArgs e)
        {
            AddPersonForm addPerson = new AddPersonForm();
            addPerson.Show();
        }

        public bool AddPerson(Person p)
        {
            foreach (Person person in persons)
            {
                if (person.Name.ToLower() == p.Name.ToLower())
                {
                    return false;
                }
            }

            persons.Add(p);
            return true;
        }

        private void add_bill_button_Click(object sender, EventArgs e)
        {
            AddBillForm aBF = new AddBillForm();
            aBF.Show();

        }

        private Person selectedPerson = null;
        private void personList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (personList.SelectedIndex != -1)
            {
                ResetDebtList();
                selectedPerson = (Person)persons[personList.SelectedIndex];

                foreach (Person owes in selectedPerson.GetDebtList().Keys)
                {
                    debtListBox.Items.Add(owes);
                }
            }
        }

        private void ResetDebtList()
        {
            debtListBox.Items.Clear();
            amountLabel.Text = "0";
        }

        private void debtListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (personList.SelectedIndex != -1 && selectedPerson != null && debtListBox.SelectedItem != null)
            {
                amountLabel.Text = selectedPerson.GetDebtList()[((Person)debtListBox.SelectedItem)].ToString();
            }
            else
            {
                amountLabel.Text = "0";
            }
        }
    }
}
