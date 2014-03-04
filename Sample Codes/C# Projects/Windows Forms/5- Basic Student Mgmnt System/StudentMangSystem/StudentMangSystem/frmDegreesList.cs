using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Model;

namespace Excercise6
{
    public partial class frmDegreesList : Form
    {
        public frmDegreesList()
        {
            InitializeComponent();
        }

        private void frmDegreesList_Load(object sender, EventArgs e)
        {

            dgvDegrees.AutoGenerateColumns = false;
            LoadDegrees();
            
        }

        private void LoadDegrees()
        {
            List<Degree> listDegree = DAL.DegreesDAL.GetAllDegress();

            dgvDegrees.DataSource = listDegree;
        }

        private void dgvDegrees_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 4) //Edit
            {
                int did = (int)dgvDegrees.CurrentRow.Cells[0].Value;

                frmNewDegree degObj = new frmNewDegree(did);
                degObj.Show();

            }
            else if (e.RowIndex >= 0 && e.ColumnIndex == 5) //Delete
            {
                var result = MessageBox.Show("Are you sure", "?",  MessageBoxButtons.YesNo);

                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    int did = (int)dgvDegrees.CurrentRow.Cells[0].Value;
                    Boolean flag = DAL.DegreesDAL.DeleteDegree(did);
                    if (flag == true)
                    {
                        LoadDegrees();
                        MessageBox.Show("Record has been deleted");
                    }
                }
            }

        }

        
    }
}
