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
    public partial class frmNewDegree : Form
    {
        Int32 did = 0;

        public frmNewDegree()
        {
            InitializeComponent();
        }

        public frmNewDegree(int id)
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

            if (txtDegreeName.Text.Trim() == "")
            {
                MessageBox.Show("Name can't be empty");
                return;
            }

            Model.Degree degObj = new Model.Degree();

            degObj.DegreeID = this.did; //For New, this will be zero
            degObj.DegreeName = txtDegreeName.Text.Trim();
            degObj.MinCrHourRequired = Int32.Parse(txtMinCrHourRequired.Text.Trim());
            degObj.MinCGPARequired = float.Parse(txtMinCGPARequired.Text.Trim());

            int id = DAL.DegreesDAL.SaveDegree(degObj);

            if (id > 0)
            {
                MessageBox.Show("Result has been saved");

                lblDegreeID.Text = "[]";
                txtDegreeName.Text = "";
                txtMinCGPARequired.Text = "";
                txtMinCrHourRequired.Text = "";

            }
        }

        private void frmNewDegree_Load(object sender, EventArgs e)
        {
            if (this.did > 0)
            {
                Model.Degree degObj = DAL.DegreesDAL.GetDegreeByID(this.did);

                if (degObj != null)
                {
                    lblDegreeID.Text = degObj.DegreeID.ToString();
                    txtDegreeName.Text = degObj.DegreeName;
                    txtMinCrHourRequired.Text = degObj.MinCrHourRequired.ToString();
                    txtMinCGPARequired.Text = degObj.MinCGPARequired.ToString();
                
                }//End of If

            }//end of outer if
        }
    }
}
