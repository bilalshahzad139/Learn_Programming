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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void newDegreeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNewDegree newDeg = new frmNewDegree();
            newDeg.ShowDialog();
        }

        private void modifyDegreeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDegreesList frmList = new frmDegreesList();
            frmList.MdiParent = this;
            frmList.Show();
        }

        private void newStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNewStudent newStd = new frmNewStudent();
            newStd.ShowDialog();
        }

        private void modifyStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmStudentsList frmStdList = new frmStudentsList();
            frmStdList.MdiParent = this;
            frmStdList.Show();
        }
    }
}
