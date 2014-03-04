namespace Excercise6
{
    partial class frmNewStudent
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNIC = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblStudentID = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtHomeNo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMobileNo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtFavSports = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCurrentSemesterNo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.cmbDegree = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(169, 42);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(122, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(132, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "NIC";
            // 
            // txtNIC
            // 
            this.txtNIC.Location = new System.Drawing.Point(169, 68);
            this.txtNIC.Name = "txtNIC";
            this.txtNIC.Size = new System.Drawing.Size(100, 20);
            this.txtNIC.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(115, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Gender";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(98, 269);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(194, 269);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(99, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Student ID";
            // 
            // lblStudentID
            // 
            this.lblStudentID.AutoSize = true;
            this.lblStudentID.Location = new System.Drawing.Point(171, 22);
            this.lblStudentID.Name = "lblStudentID";
            this.lblStudentID.Size = new System.Drawing.Size(13, 13);
            this.lblStudentID.TabIndex = 9;
            this.lblStudentID.Text = "[]";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(105, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Home No";
            // 
            // txtHomeNo
            // 
            this.txtHomeNo.Location = new System.Drawing.Point(169, 172);
            this.txtHomeNo.Name = "txtHomeNo";
            this.txtHomeNo.Size = new System.Drawing.Size(100, 20);
            this.txtHomeNo.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(102, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Mobile No";
            // 
            // txtMobileNo
            // 
            this.txtMobileNo.Location = new System.Drawing.Point(169, 146);
            this.txtMobileNo.Name = "txtMobileNo";
            this.txtMobileNo.Size = new System.Drawing.Size(100, 20);
            this.txtMobileNo.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(99, 123);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Fav Sports";
            // 
            // txtFavSports
            // 
            this.txtFavSports.Location = new System.Drawing.Point(169, 120);
            this.txtFavSports.Name = "txtFavSports";
            this.txtFavSports.Size = new System.Drawing.Size(100, 20);
            this.txtFavSports.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(52, 227);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Current Semester No";
            // 
            // txtCurrentSemesterNo
            // 
            this.txtCurrentSemesterNo.Location = new System.Drawing.Point(169, 224);
            this.txtCurrentSemesterNo.Name = "txtCurrentSemesterNo";
            this.txtCurrentSemesterNo.Size = new System.Drawing.Size(100, 20);
            this.txtCurrentSemesterNo.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(115, 201);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Degree";
            // 
            // cmbGender
            // 
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Location = new System.Drawing.Point(169, 97);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(121, 21);
            this.cmbGender.TabIndex = 20;
            // 
            // cmbDegree
            // 
            this.cmbDegree.FormattingEnabled = true;
            this.cmbDegree.Location = new System.Drawing.Point(169, 197);
            this.cmbDegree.Name = "cmbDegree";
            this.cmbDegree.Size = new System.Drawing.Size(131, 21);
            this.cmbDegree.TabIndex = 21;
            // 
            // frmNewStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 345);
            this.Controls.Add(this.cmbDegree);
            this.Controls.Add(this.cmbGender);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtCurrentSemesterNo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtHomeNo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtMobileNo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtFavSports);
            this.Controls.Add(this.lblStudentID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNIC);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtName);
            this.Name = "frmNewStudent";
            this.Text = "New Student";
            this.Load += new System.EventHandler(this.frmNewStudent_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNIC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblStudentID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtHomeNo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMobileNo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtFavSports;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCurrentSemesterNo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.ComboBox cmbDegree;
    }
}