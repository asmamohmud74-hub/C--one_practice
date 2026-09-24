using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assigment_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnshowinfo_Click(object sender, EventArgs e)
        {
            // creating and initial variables
            string name = txtname.Text;
            string id = txtstudentid.Text;
            string dept = txtsemester.Text;
            int semester = int.Parse(txtdept.Text);

            // concate
            string full_student_info = name + " " + id + " " + dept + " " + semester;

            //display
            lbloutput.Text = full_student_info;

        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtname.Clear();
            txtstudentid.Clear();
            txtdept.Clear();
            txtsemester.Clear();

            lbloutput.Text = "";

        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
