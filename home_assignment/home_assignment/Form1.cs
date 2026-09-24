using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace home_assignment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string day_week = txtdayweek.Text;
            string month = txtmonth.Text;
            string numeric = txtnumeric.Text;
            string year = txtyear.Text;

            // concate
            string full_date = day_week + " " + month + " " + numeric + " " + year;

            // displaying
            lblytear.Text = full_date;

        }

        private void txttear_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // clear
            txtdayweek.Clear();
            txtmonth.Clear();
            txtnumeric.Clear();
            txtyear.Clear();

            lbloutput.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
