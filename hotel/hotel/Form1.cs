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
           


                string guestName = txtGuestName.Text;
                


            int nights = int.Parse(txtNight.Text);
                double pricePerNight = double.Parse(txtpriceNight.Text);

                double roomCost = nights * pricePerNight;

                double serviceTax = roomCost * 0.10;

                double discount = 0;

                if (roomCost >= 500)
                {
                    discount = roomCost * 0.10;
                }
                else if (roomCost >= 300)
                {
                    discount = roomCost * 0.05;
                }

                double totalAmount = roomCost + serviceTax - discount;

                lblServiceTax.Text = serviceTax.ToString("0.00");
                lblDiscount.Text = discount.ToString("0.00");
                lblTotalAmount.Text = totalAmount.ToString("0.00");
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
    }
    }
