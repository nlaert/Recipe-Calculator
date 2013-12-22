using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Recipe_Calculator
{
    public partial class Form1 : Form
    {
        Recipe recipe = new Recipe();
        public Form1()
        {
            InitializeComponent();
            radioPortion_CheckedChanged(null, null);
            radioIngredient_CheckedChanged(null, null);
        }

        private void radioIngredient_CheckedChanged(object sender, EventArgs e)
        {
            if (radioIngredient.Checked){
                ingredientsPanel.Enabled = true;
                if (recipe.getIngredientCounter() == 0)
                {
                    readRecipe();
                    comboBox1.DataSource = recipe.toStringArray();
                }   
            }
            else
                ingredientsPanel.Enabled = false;
        }

        private void radioPortion_CheckedChanged(object sender, EventArgs e)
        {
            if (radioPortion.Checked)
               portionsPanel.Enabled = true;

            else
                portionsPanel.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (recipe.getIngredientCounter() == 0)
            {
                readRecipe();
            }
            if (radioPortion.Checked)
            {
                calculatePortions();
            }
            else if (radioIngredient.Checked)
            {
                calculateAmount();
            }
               
        }

        private void readRecipe()
        {
            String textLine = ingredientList.Text;
            String [] text = textLine.Split(new Char[] {'\n'}, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < text.Length;i++)
                recipe.newIngredient(text[i]);
        }

        private void calculateAmount()
        {

            double newAmount = Double.Parse(newAmountText.Text);
            int idx = comboBox1.SelectedIndex;
            recipe.calculateAmountByIndex(idx, newAmount);
            ingredientList.Text = String.Concat(recipe.toStringArray());
            comboBox1.DataSource = recipe.toStringArray();
        }

        private void calculatePortions()
        {
            double orig = Double.Parse(originalPortions.Text);
            double newPortion = Double.Parse(newPortions.Text);
            recipe.calculatePortions(orig, newPortion);
            
            ingredientList.Text = String.Concat(recipe.toStringArray());
           
            //newPortions.Text = comboBox1.SelectedIndex.ToString();
        }

       
    }
}
