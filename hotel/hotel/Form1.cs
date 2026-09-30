using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hotel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)

        {
        }




        private void btnCalculate_Click(object sender, EventArgs e)
        {


            try
            {

                // Get values from TextBoxes
                string guestName = txtGuestName.Text;
                int nights = int.Parse(txtNight.Text);
                double pricePerNight = double.Parse(txtpriceNight.Text);

                // Calculate room cost
                double roomCost = nights * pricePerNight;

                // Service Tax 
                double serviceTax = roomCost * 0.10;

                // Discount
                double discount = roomCost * 0.05;


                // Calculate total
                double totalAmount = roomCost + serviceTax - discount;

                // display result
                lblServiceTax.Text = serviceTax.ToString();
                lblDiscount.Text = discount.ToString();
                lblTotalAmount.Text = totalAmount.ToString();

            }
            catch (Exception)
            {
                MessageBox.Show("Soo geli xog saxan");
            }
                
            }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblServiceTax_Click(object sender, EventArgs e)
        {

        }

        private void txtguestnumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtpriceNight_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNight_TextChanged(object sender, EventArgs e)
        {

        }
        
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
    }
