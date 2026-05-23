using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItemNamespace
{
    public class DiscountedItem : Item
    {
        private double item_discount;
        private double discounted_price;
        private double payment_amount;
        private double change;

       
        public DiscountedItem(string name, double price, int quantity, double discount)
            : base(name, price, quantity)
        {
            this.item_discount = discount;
        }

        // Overriding the abstract method 
        public override double getTotalPrice()
        {
            // : Convert discount to decimal, calculate discounted price, then total
            double discountAmount = item_price * (item_discount * 0.01);
            discounted_price = item_price - discountAmount;

            return discounted_price * item_quantity;
        }

        // Overriding the abstract method to set payment
        public override void setPayment(double amount)
        {
            this.payment_amount = amount;
        }

        // Method to calculate and return the change
        public double getChange()
        {
            change = payment_amount - getTotalPrice();
            return change;
        }
    }
}
