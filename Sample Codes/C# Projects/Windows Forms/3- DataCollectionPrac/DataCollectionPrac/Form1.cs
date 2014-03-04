using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Excercise5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbCity.Items.Clear();
            if (cmbCountry.SelectedItem == "Pakistan")
            {
                cmbCity.Items.Add("Lahore");
                cmbCity.Items.Add("Karachi");
            }
            else if (cmbCountry.SelectedItem == "India")
            {
                cmbCity.Items.Add("Delhi");
                cmbCity.Items.Add("Bombay");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String id = mtextID.Text;
            String name = txtName.Text;
            String fname = txtFatherName.Text;
            int age = (int)nudAge.Value;
            String country = cmbCountry.SelectedItem.ToString();
            String city = cmbCity.SelectedItem.ToString();
            String gender = "";
            if (rdoMale.Checked)
            {
                gender = "Male";
            }
            else
            {
                gender = "Female";
            }

            Student stdObj = new Student();

            stdObj.ID = id;
            stdObj.Name = name;
            stdObj.FatherName = fname;
            stdObj.Age = age;
            stdObj.Country = country;
            stdObj.City = city;
            stdObj.Gender = gender;

            this.Hide();
            Form2 frm = new Form2(stdObj);
            frm.ShowDialog();

        }
    }
}
