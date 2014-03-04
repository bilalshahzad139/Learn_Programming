using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Excercise6
{
    public partial class frmStart : Form
    {
        public frmStart()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 obj = new Form1();
            obj.Show();
        }
    }
}
