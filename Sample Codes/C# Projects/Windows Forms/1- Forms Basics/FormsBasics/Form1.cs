using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Excercise3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {            
            btnObject.Left = btnObject.Left +10;
            if (btnObject.Right >= this.Width)
            {
                btnObject.Left = this.Width - btnObject.Width;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            btnObject.Left = btnObject.Left - 10;
            if (btnObject.Left <= 0)
            {
                btnObject.Left = 0;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            btnObject.Top = btnObject.Top - 10;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            btnObject.Top = btnObject.Top + 10;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this.Width.ToString());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this.Height.ToString());
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MessageBox.Show(btnObject.Left.ToString());
        }

        private void button9_Click(object sender, EventArgs e)
        {
            MessageBox.Show(btnObject.Top.ToString());
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show(btnObject.Width.ToString());
        }

        private void button10_Click(object sender, EventArgs e)
        {
            MessageBox.Show(btnObject.Height.ToString());
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
