namespace Excercise6
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.degreesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newDegreeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifyDegreeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifyStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.degreesToolStripMenuItem,
            this.studentsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(910, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // degreesToolStripMenuItem
            // 
            this.degreesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newDegreeToolStripMenuItem,
            this.modifyDegreeToolStripMenuItem});
            this.degreesToolStripMenuItem.Name = "degreesToolStripMenuItem";
            this.degreesToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.degreesToolStripMenuItem.Text = "Degrees";
            // 
            // newDegreeToolStripMenuItem
            // 
            this.newDegreeToolStripMenuItem.Name = "newDegreeToolStripMenuItem";
            this.newDegreeToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.newDegreeToolStripMenuItem.Text = "New Degree";
            this.newDegreeToolStripMenuItem.Click += new System.EventHandler(this.newDegreeToolStripMenuItem_Click);
            // 
            // modifyDegreeToolStripMenuItem
            // 
            this.modifyDegreeToolStripMenuItem.Name = "modifyDegreeToolStripMenuItem";
            this.modifyDegreeToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.modifyDegreeToolStripMenuItem.Text = "Modify Degree";
            this.modifyDegreeToolStripMenuItem.Click += new System.EventHandler(this.modifyDegreeToolStripMenuItem_Click);
            // 
            // studentsToolStripMenuItem
            // 
            this.studentsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newStudentToolStripMenuItem,
            this.modifyStudentToolStripMenuItem});
            this.studentsToolStripMenuItem.Name = "studentsToolStripMenuItem";
            this.studentsToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.studentsToolStripMenuItem.Text = "Students";
            // 
            // newStudentToolStripMenuItem
            // 
            this.newStudentToolStripMenuItem.Name = "newStudentToolStripMenuItem";
            this.newStudentToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.newStudentToolStripMenuItem.Text = "New Student";
            this.newStudentToolStripMenuItem.Click += new System.EventHandler(this.newStudentToolStripMenuItem_Click);
            // 
            // modifyStudentToolStripMenuItem
            // 
            this.modifyStudentToolStripMenuItem.Name = "modifyStudentToolStripMenuItem";
            this.modifyStudentToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.modifyStudentToolStripMenuItem.Text = "Modify Student";
            this.modifyStudentToolStripMenuItem.Click += new System.EventHandler(this.modifyStudentToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 432);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem degreesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newDegreeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifyDegreeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newStudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifyStudentToolStripMenuItem;
    }
}