using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recipe_Calculator
{
    class Ingredient
    {
        private double Amount;
        private String Name;

        public Ingredient(double amount, String name)
        {
            this.Amount = amount;
            this.Name = name;
        }

        public Ingredient(String name)
        {
            this.Amount = 0;
            this.Name = name;
        }

        
        public override String ToString()
        {
            if(HasAmount())
                return Amount + " " + Name;
            return Name;
        }

        public bool HasAmount()
        {
            return Amount != 0;
        }
        public double GetAmount()
        {
            return Amount;
        }

        internal void SetAmount(double amount)
        {
            this.Amount = amount;
        }
    }
}
