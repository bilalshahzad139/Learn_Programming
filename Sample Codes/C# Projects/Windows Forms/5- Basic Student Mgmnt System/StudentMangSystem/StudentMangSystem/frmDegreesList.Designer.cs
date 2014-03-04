namespace Excercise6
{
    partial class frmDegreesList
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
            this.dgvDegrees = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDegrees)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDegrees
            // 
            this.dgvDegrees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDegrees.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dgvDegrees.Location = new System.Drawing.Point(12, 12);
            this.dgvDegrees.Name = "dgvDegrees";
            this.dgvDegrees.Size = new System.Drawing.Size(727, 375);
            this.dgvDegrees.TabIndex = 0;
            this.dgvDegrees.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDegrees_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "DegreeID";
            this.Column1.HeaderText = "DegreeID";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "DegreeName";
            this.Column2.HeaderText = "Degree Name";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "MinCrHourRequired";
            this.Column3.HeaderText = "Min Cr";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "MinCGPARequired";
            this.Column4.HeaderText = "Min CGPA";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Column5.HeaderText = "Edit";
            this.Column5.Name = "Column5";
            this.Column5.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column5.Text = "Edit";
            this.Column5.UseColumnTextForButtonValue = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Delete";
            this.Column6.Name = "Column6";
            this.Column6.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column6.Text = "Delete";
            this.Column6.UseColumnTextForButtonValue = true;
            // 
            // frmDegreesList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 399);
            this.Controls.Add(this.dgvDegrees);
            this.Name = "frmDegreesList";
            this.Text = "Degrees List";
            this.Load += new System.EventHandler(this.frmDegreesList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDegrees)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDegrees;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewButtonColumn Column5;
        private System.Windows.Forms.DataGridViewButtonColumn Column6;
    }
}