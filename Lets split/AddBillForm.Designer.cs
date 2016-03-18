namespace Lets_split
{
    partial class AddBillForm
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
            this.buyerBox = new System.Windows.Forms.ComboBox();
            this.createButton = new System.Windows.Forms.Button();
            this.amountBox = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.personsListBox = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.payingFor = new System.Windows.Forms.Label();
            this.personCounter = new System.Windows.Forms.NumericUpDown();
            this.participatingCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.amountBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.personCounter)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // buyerBox
            // 
            this.buyerBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.buyerBox.FormattingEnabled = true;
            this.buyerBox.Location = new System.Drawing.Point(65, 25);
            this.buyerBox.Name = "buyerBox";
            this.buyerBox.Size = new System.Drawing.Size(121, 21);
            this.buyerBox.TabIndex = 1;
            // 
            // createButton
            // 
            this.createButton.Location = new System.Drawing.Point(51, 126);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(75, 23);
            this.createButton.TabIndex = 2;
            this.createButton.Text = "Create";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // amountBox
            // 
            this.amountBox.DecimalPlaces = 2;
            this.amountBox.Location = new System.Drawing.Point(66, 52);
            this.amountBox.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.amountBox.Name = "amountBox";
            this.amountBox.Size = new System.Drawing.Size(120, 20);
            this.amountBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Buyer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Amount";
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(132, 126);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 7;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // personsListBox
            // 
            this.personsListBox.FormattingEnabled = true;
            this.personsListBox.Location = new System.Drawing.Point(7, 19);
            this.personsListBox.Name = "personsListBox";
            this.personsListBox.Size = new System.Drawing.Size(124, 121);
            this.personsListBox.TabIndex = 8;
            this.personsListBox.SelectedIndexChanged += new System.EventHandler(this.personsListBox_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.payingFor);
            this.groupBox1.Controls.Add(this.personCounter);
            this.groupBox1.Controls.Add(this.participatingCheckBox);
            this.groupBox1.Controls.Add(this.personsListBox);
            this.groupBox1.Location = new System.Drawing.Point(238, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(307, 154);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Participants";
            // 
            // payingFor
            // 
            this.payingFor.AutoSize = true;
            this.payingFor.Location = new System.Drawing.Point(176, 44);
            this.payingFor.Name = "payingFor";
            this.payingFor.Size = new System.Drawing.Size(93, 13);
            this.payingFor.TabIndex = 1;
            this.payingFor.Text = "Pays for x persons";
            // 
            // personCounter
            // 
            this.personCounter.Location = new System.Drawing.Point(137, 42);
            this.personCounter.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.personCounter.Name = "personCounter";
            this.personCounter.Size = new System.Drawing.Size(33, 20);
            this.personCounter.TabIndex = 10;
            this.personCounter.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.personCounter.ValueChanged += new System.EventHandler(this.personCounter_ValueChanged);
            // 
            // participatingCheckBox
            // 
            this.participatingCheckBox.AutoSize = true;
            this.participatingCheckBox.Location = new System.Drawing.Point(137, 19);
            this.participatingCheckBox.Name = "participatingCheckBox";
            this.participatingCheckBox.Size = new System.Drawing.Size(84, 17);
            this.participatingCheckBox.TabIndex = 9;
            this.participatingCheckBox.Text = "Participating";
            this.participatingCheckBox.UseVisualStyleBackColor = true;
            this.participatingCheckBox.CheckedChanged += new System.EventHandler(this.participatingCheckBox_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.buyerBox);
            this.groupBox2.Controls.Add(this.amountBox);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(32, 20);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "The Bill";
            // 
            // AddBillForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 173);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.createButton);
            this.Name = "AddBillForm";
            this.Text = "AddBillForm";
            ((System.ComponentModel.ISupportInitialize)(this.amountBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.personCounter)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox buyerBox;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.NumericUpDown amountBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.ListBox personsListBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label payingFor;
        private System.Windows.Forms.NumericUpDown personCounter;
        private System.Windows.Forms.CheckBox participatingCheckBox;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}