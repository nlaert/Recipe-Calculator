using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recipe_Calculator
{
    class Ingredient
    {
        private double amount;
        private String name;

        public Ingredient(double amount, String name)
        {
            this.amount = amount;
            this.name = name;
        }

        public String toString()
        {
            return amount + " " + name;
        }

        public double getAmount()
        {
            return amount;
        }

        internal void setAmount(double amount)
        {
            this.amount = amount;
        }
    }
}
