namespace Excercise3
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.textBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(36, 22);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(202, 20);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(256, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(197, 30);
            this.button1.TabIndex = 1;
            this.button1.Text = "Show Selected Date";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(256, 48);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(197, 30);
            this.button2.TabIndex = 3;
            this.button2.Text = "Show Selected Time";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker2.Location = new System.Drawing.Point(36, 58);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(187, 20);
            this.dateTimePicker2.TabIndex = 2;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "--Select--",
            "Lahore,",
            "Karachi"});
            this.comboBox1.Location = new System.Drawing.Point(36, 96);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(187, 21);
            this.comboBox1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(253, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "This drop down is loaded at design time";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(253, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(240, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "This drop down is loaded at run time (in form load)";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(36, 123);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(187, 21);
            this.comboBox2.TabIndex = 6;
            // 
            // comboBox3
            // 
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(67, 199);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(278, 21);
            this.comboBox3.TabIndex = 8;
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(216, 170);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(129, 23);
            this.button3.TabIndex = 9;
            this.button3.Text = "Add to Combo Box";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(67, 170);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(143, 20);
            this.textBox1.TabIndex = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(25, 275);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(177, 93);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "JPG File |*.jpg";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(25, 246);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(177, 23);
            this.button4.TabIndex = 12;
            this.button4.Text = "Select Picture";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(256, 246);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(334, 23);
            this.button5.TabIndex = 13;
            this.button5.Text = "Select Text file to load";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.Filter = "Text Files|*.txt";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(256, 275);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox2.Size = new System.Drawing.Size(334, 124);
            this.textBox2.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 411);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "Form1";
            this.Text = "Check it and Do it";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.TextBox textBox2;
    }
}