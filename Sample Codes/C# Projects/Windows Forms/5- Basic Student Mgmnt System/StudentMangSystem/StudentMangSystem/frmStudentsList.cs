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
    public partial class frmStudentsList : Form
    {
        public frmStudentsList()
        {
            InitializeComponent();
        }

        private void frmStudentsList_Load(object sender, EventArgs e)
        {

            dgvStudents.AutoGenerateColumns = false;
            LoadStudents();
            
        }

        private void LoadStudents()
        {
            List<Student> listStudent = DAL.StudentsDAL.GetAllStudents();

            dgvStudents.DataSource = listStudent;
        }

        

        private void dgvStudents_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 9) //Edit
            {
                int did = (int)dgvStudents.CurrentRow.Cells[0].Value;

                frmNewStudent degObj = new frmNewStudent(did);
                degObj.Show();

            }
            else if (e.RowIndex >= 0 && e.ColumnIndex == 10) //Delete
            {
                var result = MessageBox.Show("Are you sure", "?",  MessageBoxButtons.YesNo);

                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    int did = (int)dgvStudents.CurrentRow.Cells[0].Value;
                    Boolean flag = DAL.StudentsDAL.DeleteStudent(did);
                    if (flag == true)
                    {
                        LoadStudents();
                        MessageBox.Show("Record has been deleted");
                    }
                }
            }

        }

        
    }
}
