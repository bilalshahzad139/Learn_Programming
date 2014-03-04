using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Excercise6
{
    public partial class Form1 : Form
    {
        String fileName = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtData.Text = "";
            fileName = "";
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fileName == "")
            {
                var result = saveFileDialog1.ShowDialog();
                if (result == System.Windows.Forms.DialogResult.OK)
                {
                    fileName = saveFileDialog1.FileName;
                }
            }
            if (fileName != "")
            {
                TextWriter writer = new StreamWriter(fileName);
                writer.Write(txtData.Text);
                writer.Flush();
                writer.Close();
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var result = openFileDialog1.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                fileName = openFileDialog1.FileName;
                StreamReader reader = new StreamReader(fileName);
                String text = reader.ReadToEnd();
                txtData.Text = text;
                reader.Close();
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var result = saveFileDialog1.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                fileName = saveFileDialog1.FileName;

                if (fileName != "")
                {
                    StreamWriter writer = new StreamWriter(fileName);
                    writer.Write(txtData.Text);
                    writer.Flush();
                    writer.Close();
                }
            }

        }

        private void existToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
