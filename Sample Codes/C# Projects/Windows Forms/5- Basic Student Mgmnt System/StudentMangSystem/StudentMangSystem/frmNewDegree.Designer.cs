namespace Excercise6
{
    partial class frmNewDegree
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
            this.txtDegreeName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMinCrHourRequired = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMinCGPARequired = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblDegreeID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtDegreeName
            // 
            this.txtDegreeName.Location = new System.Drawing.Point(169, 42);
            this.txtDegreeName.Name = "txtDegreeName";
            this.txtDegreeName.Size = new System.Drawing.Size(100, 20);
            this.txtDegreeName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Degree Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "MinCrHourRequired";
            // 
            // txtMinCrHourRequired
            // 
            this.txtMinCrHourRequired.Location = new System.Drawing.Point(169, 68);
            this.txtMinCrHourRequired.Name = "txtMinCrHourRequired";
            this.txtMinCrHourRequired.Size = new System.Drawing.Size(100, 20);
            this.txtMinCrHourRequired.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "MinCGPARequired";
            // 
            // txtMinCGPARequired
            // 
            this.txtMinCGPARequired.Location = new System.Drawing.Point(169, 94);
            this.txtMinCGPARequired.Name = "txtMinCGPARequired";
            this.txtMinCGPARequired.Size = new System.Drawing.Size(100, 20);
            this.txtMinCGPARequired.TabIndex = 4;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(73, 142);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(169, 142);
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
            this.label4.Location = new System.Drawing.Point(92, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Degree ID";
            // 
            // lblDegreeID
            // 
            this.lblDegreeID.AutoSize = true;
            this.lblDegreeID.Location = new System.Drawing.Point(171, 22);
            this.lblDegreeID.Name = "lblDegreeID";
            this.lblDegreeID.Size = new System.Drawing.Size(13, 13);
            this.lblDegreeID.TabIndex = 9;
            this.lblDegreeID.Text = "[]";
            // 
            // frmNewDegree
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 220);
            this.Controls.Add(this.lblDegreeID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMinCGPARequired);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMinCrHourRequired);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDegreeName);
            this.Name = "frmNewDegree";
            this.Text = "New Degree";
            this.Load += new System.EventHandler(this.frmNewDegree_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDegreeName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMinCrHourRequired;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMinCGPARequired;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblDegreeID;
    }
}