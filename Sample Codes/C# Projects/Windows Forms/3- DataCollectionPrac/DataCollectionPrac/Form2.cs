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
    public partial class Form2 : Form
    {
        Student std = new Student();
        public Form2()
        {
            InitializeComponent();
        }
        public Form2(Student s)
        {
            std = s;
            InitializeComponent();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            lblID.Text = std.ID;
            lblName.Text = std.Name;
            lblFatherName.Text = std.FatherName;
            lblAge.Text = std.Age.ToString();
            lblCountry.Text = std.Country;
            lblCity.Text = std.City;
            lblGender.Text = std.Gender;
        }
    }
}
