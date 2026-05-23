using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ItemNamespace;

namespace HandsonAct1
{
    public partial class Form1 : Form
    {
        private DiscountedItem itemToPurchase;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCompute_Click(object sender, EventArgs e)
        {
           
            try
            {
                // Get the text for all
                string name = txtItemName.Text;
                double price = Convert.ToDouble(txtPrice.Text);
                double discount = Convert.ToDouble(txtDiscount.Text);
                int quantity = Convert.ToInt32(txtQuantity.Text);

                // Create the Discounted object
                itemToPurchase = new DiscountedItem(name, price, quantity, discount);

                // Compute the total price and display
                lblTotalAmount.Text = itemToPurchase.getTotalPrice().ToString("F2");
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid numbers for Price, Discount, and Quantity.");
            }
        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                // Making sur the user clicked Compute first
                if (itemToPurchase != null)
                {
                    // Get  payment amount
                    double payment = Convert.ToDouble(txtPayment.Text);
                    itemToPurchase.setPayment(payment);

                    // Compute and display the change
                    lblChange.Text = itemToPurchase.getChange().ToString("F2");
                }
                else
                {
                    MessageBox.Show("Please compute the total amount first.");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a valid payment amount.");
            }
        }
    }
}
