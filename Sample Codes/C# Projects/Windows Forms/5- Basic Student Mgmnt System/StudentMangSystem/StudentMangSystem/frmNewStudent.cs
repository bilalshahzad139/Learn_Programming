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
    public partial class frmNewStudent : Form
    {
        Int32 did = 0;

        public frmNewStudent()
        {
            InitializeComponent();
        }

        public frmNewStudent(int id)
        {
            this.did = id;
            InitializeComponent();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (txtName.Text.Trim() == "")
            {
                MessageBox.Show("Name can't be empty");
                return;
            }

            Model.Student degObj = new Model.Student();

            degObj.StudentID = this.did; //For New, this will be zero
            degObj.Name = txtName.Text.Trim();
            degObj.NIC = txtNIC.Text.Trim();
            degObj.Gender = cmbGender.SelectedValue.ToString();
            degObj.FavSports = txtFavSports.Text.Trim();
            degObj.MobileNo = txtMobileNo.Text.Trim();
            degObj.HomeNo = txtHomeNo.Text.Trim();
            degObj.DegreeID = Convert.ToInt32(cmbDegree.SelectedValue);
            degObj.CurrentSemesterNo = Convert.ToInt32(txtCurrentSemesterNo.Text.Trim());

            int id = DAL.StudentsDAL.SaveStudent(degObj);

            if (id > 0)
            {
                MessageBox.Show("Data has been saved");

                lblStudentID.Text = "";
                txtName.Text = "";
                txtNIC.Text = "";
                cmbGender.SelectedIndex = 0;
                txtFavSports.Text = "";
                txtMobileNo.Text = "";
                txtHomeNo.Text = "";
                cmbDegree.SelectedIndex = 0;
                txtCurrentSemesterNo.Text = "";

            }
        }

        private void frmNewStudent_Load(object sender, EventArgs e)
        {
            LoadCombos();

            if (this.did > 0)
            {
                Model.Student degObj = DAL.StudentsDAL.GetStudentByID(this.did);

                if (degObj != null)
                {
                    lblStudentID.Text = degObj.StudentID.ToString();
                    txtName.Text = degObj.Name;
                    txtNIC.Text = degObj.NIC;
                    cmbGender.SelectedValue = degObj.Gender;
                    txtFavSports.Text = degObj.FavSports;
                    txtMobileNo.Text = degObj.MobileNo;
                    txtHomeNo.Text = degObj.HomeNo;
                    cmbDegree.SelectedValue = degObj.DegreeID;
                    txtCurrentSemesterNo.Text = degObj.CurrentSemesterNo.ToString();
                
                }//End of If

            }//end of outer if
        }

        private void LoadCombos()
        {
            List<Degree> listDegrees = DAL.DegreesDAL.GetAllDegress();

            cmbDegree.DisplayMember = "DegreeName";
            cmbDegree.ValueMember = "DegreeID";
            cmbDegree.DataSource = listDegrees;

            List<ComboItem> list = new List<ComboItem>();

            ComboItem item = new ComboItem();
            item.ID = "Male";
            item.Name = "Male";
            list.Add(item);

            item = new ComboItem();
            item.ID = "FeMale";
            item.Name = "FeMale";
            list.Add(item);

            cmbGender.DisplayMember = "Name";
            cmbGender.ValueMember = "ID";
            cmbGender.DataSource = list;
            
        }
    }//end of class


    public class ComboItem
    {
        public String ID
        {
            get;
            set;
        }
        public String Name
        {
            get;
            set;
        }
    }
}
