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
            // 2. ADD THIS LINE: The 'try' block must start here
            try
            {
                // Get the text from the textboxes and convert them to the right data types
                string name = txtItemName.Text;
                double price = Convert.ToDouble(txtPrice.Text);
                double discount = Convert.ToDouble(txtDiscount.Text);
                int quantity = Convert.ToInt32(txtQuantity.Text);

                // Create the DiscountedItem object
                itemToPurchase = new DiscountedItem(name, price, quantity, discount);

                // Compute the total price and display it with 2 decimal places ("F2")
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
                // Make sure the user clicked Compute first
                if (itemToPurchase != null)
                {
                    // Get the payment amount
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