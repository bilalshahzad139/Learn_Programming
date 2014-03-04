namespace Excercise5
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFatherName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbCountry = new System.Windows.Forms.ComboBox();
            this.cmbCity = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.rdoMale = new System.Windows.Forms.RadioButton();
            this.rdoFemale = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.nudAge = new System.Windows.Forms.NumericUpDown();
            this.mtextID = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudAge)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(146, 217);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(227, 32);
            this.button1.TabIndex = 0;
            this.button1.Text = "Get Data and Send to Next Form";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(119, 49);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(170, 20);
            this.txtName.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Name";
            // 
            // txtFatherName
            // 
            this.txtFatherName.Location = new System.Drawing.Point(119, 75);
            this.txtFatherName.Name = "txtFatherName";
            this.txtFatherName.Size = new System.Drawing.Size(170, 20);
            this.txtFatherName.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Father Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(86, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Age";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(69, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Country";
            // 
            // cmbCountry
            // 
            this.cmbCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCountry.FormattingEnabled = true;
            this.cmbCountry.Items.AddRange(new object[] {
            "Pakistan",
            "India"});
            this.cmbCountry.Location = new System.Drawing.Point(119, 130);
            this.cmbCountry.Name = "cmbCountry";
            this.cmbCountry.Size = new System.Drawing.Size(170, 21);
            this.cmbCountry.TabIndex = 10;
            this.cmbCountry.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // cmbCity
            // 
            this.cmbCity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCity.FormattingEnabled = true;
            this.cmbCity.Items.AddRange(new object[] {
            "Pakistan",
            "India"});
            this.cmbCity.Location = new System.Drawing.Point(119, 157);
            this.cmbCity.Name = "cmbCity";
            this.cmbCity.Size = new System.Drawing.Size(170, 21);
            this.cmbCity.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(88, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "City";
            // 
            // rdoMale
            // 
            this.rdoMale.AutoSize = true;
            this.rdoMale.Location = new System.Drawing.Point(119, 185);
            this.rdoMale.Name = "rdoMale";
            this.rdoMale.Size = new System.Drawing.Size(48, 17);
            this.rdoMale.TabIndex = 13;
            this.rdoMale.TabStop = true;
            this.rdoMale.Text = "Male";
            this.rdoMale.UseVisualStyleBackColor = true;
            // 
            // rdoFemale
            // 
            this.rdoFemale.AutoSize = true;
            this.rdoFemale.Location = new System.Drawing.Point(173, 185);
            this.rdoFemale.Name = "rdoFemale";
            this.rdoFemale.Size = new System.Drawing.Size(59, 17);
            this.rdoFemale.TabIndex = 14;
            this.rdoFemale.TabStop = true;
            this.rdoFemale.Text = "Female";
            this.rdoFemale.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(70, 189);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Gender";
            // 
            // nudAge
            // 
            this.nudAge.Location = new System.Drawing.Point(119, 102);
            this.nudAge.Maximum = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.nudAge.Minimum = new decimal(new int[] {
            18,
            0,
            0,
            0});
            this.nudAge.Name = "nudAge";
            this.nudAge.Size = new System.Drawing.Size(58, 20);
            this.nudAge.TabIndex = 16;
            this.nudAge.Value = new decimal(new int[] {
            18,
            0,
            0,
            0});
            // 
            // mtextID
            // 
            this.mtextID.Location = new System.Drawing.Point(119, 26);
            this.mtextID.Mask = "00000-000000-0";
            this.mtextID.Name = "mtextID";
            this.mtextID.Size = new System.Drawing.Size(170, 20);
            this.mtextID.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 322);
            this.Controls.Add(this.mtextID);
            this.Controls.Add(this.nudAge);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.rdoFemale);
            this.Controls.Add(this.rdoMale);
            this.Controls.Add(this.cmbCity);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbCountry);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtFatherName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nudAge)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFatherName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbCountry;
        private System.Windows.Forms.ComboBox cmbCity;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton rdoMale;
        private System.Windows.Forms.RadioButton rdoFemale;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nudAge;
        private System.Windows.Forms.MaskedTextBox mtextID;
    }
}