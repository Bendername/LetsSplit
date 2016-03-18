namespace Lets_split
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.personList = new System.Windows.Forms.ListBox();
            this.add_person = new System.Windows.Forms.Button();
            this.add_bill_button = new System.Windows.Forms.Button();
            this.debtListBox = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.amountLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // personList
            // 
            this.personList.FormattingEnabled = true;
            this.personList.Location = new System.Drawing.Point(12, 61);
            this.personList.Name = "personList";
            this.personList.Size = new System.Drawing.Size(205, 290);
            this.personList.TabIndex = 0;
            this.personList.SelectedIndexChanged += new System.EventHandler(this.personList_SelectedIndexChanged);
            // 
            // add_person
            // 
            this.add_person.Location = new System.Drawing.Point(12, 32);
            this.add_person.Name = "add_person";
            this.add_person.Size = new System.Drawing.Size(75, 23);
            this.add_person.TabIndex = 1;
            this.add_person.Text = "Add Person";
            this.add_person.UseVisualStyleBackColor = true;
            this.add_person.Click += new System.EventHandler(this.add_person_Click);
            // 
            // add_bill_button
            // 
            this.add_bill_button.Location = new System.Drawing.Point(93, 32);
            this.add_bill_button.Name = "add_bill_button";
            this.add_bill_button.Size = new System.Drawing.Size(75, 23);
            this.add_bill_button.TabIndex = 2;
            this.add_bill_button.Text = "Add Bill";
            this.add_bill_button.UseVisualStyleBackColor = true;
            this.add_bill_button.Click += new System.EventHandler(this.add_bill_button_Click);
            // 
            // debtListBox
            // 
            this.debtListBox.FormattingEnabled = true;
            this.debtListBox.Location = new System.Drawing.Point(18, 29);
            this.debtListBox.Name = "debtListBox";
            this.debtListBox.Size = new System.Drawing.Size(179, 108);
            this.debtListBox.TabIndex = 3;
            this.debtListBox.SelectedIndexChanged += new System.EventHandler(this.debtListBox_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.amountLabel);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.debtListBox);
            this.groupBox1.Location = new System.Drawing.Point(252, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(276, 159);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Debt";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(203, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Amount";
            // 
            // amountLabel
            // 
            this.amountLabel.AutoSize = true;
            this.amountLabel.Location = new System.Drawing.Point(203, 42);
            this.amountLabel.Name = "amountLabel";
            this.amountLabel.Size = new System.Drawing.Size(13, 13);
            this.amountLabel.TabIndex = 1;
            this.amountLabel.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 469);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.add_bill_button);
            this.Controls.Add(this.add_person);
            this.Controls.Add(this.personList);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox personList;
        private System.Windows.Forms.Button add_person;
        private System.Windows.Forms.Button add_bill_button;
        private System.Windows.Forms.ListBox debtListBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label amountLabel;
    }
}

