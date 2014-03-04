using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

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
            MessageBox.Show(dateTimePicker1.Value.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(dateTimePicker1.Value.ToShortTimeString());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox2.Items.Add("--Select--");
            comboBox2.Items.Add("Lahore");
            comboBox2.Items.Add("Karachi");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string s = textBox1.Text.Trim();
            if (s == "")
            {
                MessageBox.Show("text is empty");
            }
            else
            {
                comboBox3.Items.Add(s);
                MessageBox.Show("Now, Total items in combobox are " + comboBox3.Items.Count);
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show("You have selected " + comboBox3.SelectedItem.ToString());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var result = openFileDialog1.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                string file = openFileDialog1.FileName;
                pictureBox1.Load(file);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var result = openFileDialog2.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                string file = openFileDialog2.FileName;
                StreamReader reader = new StreamReader(file);
                textBox2.Text = reader.ReadToEnd();
                reader.Close();
            }
        }
    }
}
