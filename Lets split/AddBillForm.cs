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
    public partial class AddBillForm : Form
    {
        public AddBillForm()
        {
            InitializeComponent();
            bool first = true;
            foreach (Person p in Form1.instance.persons)
            {
                buyerBox.Items.Add(p);
                if (first)
                {
                    buyerBox.SelectedItem = p;
                    first = false;
                }
                personsListBox.Items.Add(new BillPerson(p));
            }
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            Bill bill = new Bill(((Person)buyerBox.SelectedItem));
            int numberOfParticipants = personsListBox.Items.Cast<BillPerson>().Sum(x => (x.participating==true) ? x.weight : 0);
            foreach (BillPerson bp in personsListBox.Items)
            {
                if (bp.participating && bill.Buyer.Name != bp.Name)
                {
                    bill.distribution.Add(bp.Name, (double)amountBox.Value * ((double)bp.weight / numberOfParticipants));
                }
            }
            Form1.instance.AddBill(bill);
            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void personsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (personsListBox.SelectedIndex != -1)
            {
                participatingCheckBox.Checked = ((BillPerson)personsListBox.Items[personsListBox.SelectedIndex]).participating;
                personCounter.Value = ((BillPerson)personsListBox.Items[personsListBox.SelectedIndex]).weight;
            }
            else
            {
                participatingCheckBox.Checked = false;
                personCounter.Value = 1;
            }
        }

        private void personCounter_ValueChanged(object sender, EventArgs e)
        {
            ((BillPerson)personsListBox.Items[personsListBox.SelectedIndex]).weight = (int)personCounter.Value;
        }

        private void participatingCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (personsListBox.SelectedIndex != -1)
            {
                ((BillPerson)personsListBox.Items[personsListBox.SelectedIndex]).participating = participatingCheckBox.Checked;
            }
        }
    }
}
