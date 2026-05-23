using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItemNamespace
{
    public abstract class Item
    {
        // Protected fields accessible 
        protected string item_name;
        protected double item_price;
        protected int item_quantity;

        // Private field
        private double total_price;

        // Constructor
        public Item(string name, double price, int quantity)
        {
            this.item_name = name;
            this.item_price = price;
            this.item_quantity = quantity;
        }

        // Abstract methods to be overridden 
        public abstract double getTotalPrice();
        public abstract void setPayment(double amount);
    }
}
