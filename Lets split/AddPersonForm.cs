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
    public partial class AddPersonForm : Form
    {
        public AddPersonForm()
        {
            InitializeComponent();
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            if (Form1.instance.AddPerson(new Person(nameBox.Text)))
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Sorry a person with that name already exists");
            }
        }
    }
}
