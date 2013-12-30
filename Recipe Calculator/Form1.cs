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
        
        private Recipe recipe = new Recipe();
        private const String  ErrorMessage = "O valor inserido não é válido.";
        private const String ErrorTitle = "Valor Inválido";
        public Form1()
        {
            InitializeComponent();
            
            radioIngredient_CheckedChanged(null, null);
            radioPortion_CheckedChanged(null, null);
        }

        private void radioIngredient_CheckedChanged(object sender, EventArgs e)
        {
            if (radioIngredient.Checked){
                ingredientsPanel.Enabled = true;
                if (recipe.GetIngredientCounter() == 0)
                {
                    if(!ReadRecipe())
                        ingredientsPanel.Enabled = false;
                    UpdateComboBox();
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

        private void calculateBt_Click(object sender, EventArgs e)
        {
            if (recipe.GetIngredientCounter() == 0)
            {
                if (!ReadRecipe())
                    TextBoxInvalidValue(ingredientList);
                    recipe = new Recipe();
                    return;
            }
            if (radioPortion.Checked)
            {
                CalculatePortions();
            }
            else if (radioIngredient.Checked)
            {
                CalculateAmount();
            }

        }

        private void update_Click(object sender, EventArgs e)
        {
            recipe = new Recipe();
            if (!ReadRecipe())
                return;
            ResetColors();
            UpdateComboBox();
        }

        private void clean_Click(object sender, EventArgs e)
        {
            recipe = new Recipe();
            Clean();
        }

        private bool ReadRecipe()
        {
            String textLine = ingredientList.Text;
            String [] text = textLine.Split(new Char[] {'\n'}, StringSplitOptions.RemoveEmptyEntries);
            return recipe.ReadRecipe(text);
            //for (int i = 0; i < text.Length; i++)
            //{
            //    try
            //    {
            //        recipe.NewIngredient(text[i]);
            //    }
            //    catch(FormatException){
            //        TextBoxInvalidValue(ingredientList);
            //        recipe = new Recipe();
            //        return false;
            //    }
            //}
            //return true;     
        }

        private void CalculateAmount()
        {
            double newAmount = TextBoxToDouble(newAmountText);
            if (newAmount > 0)
            {
                int idx = comboBox1.SelectedIndex;
                if (recipe.CalculateAmountByIndex(idx, newAmount))
                {
                     PrintRecipe();
                     UpdateComboBox();
                }
            }
        }

        private void CalculatePortions()
        {
            double orig = TextBoxToDouble(originalPortions);
            double newPortion = TextBoxToDouble(newPortions);
            if (orig > 0 && newPortion > 0)
            {
                recipe.CalculatePortions(orig, newPortion);
                PrintRecipe();
            }
        }

        private void PrintRecipe()
        {
            ingredientList.Text = recipe.ToString();
            ResetColors();
        }

        private String Concat(String[] strings)
        {
            String ret = strings[0];
            for (int i = 1; i < strings.Length; i++)
            {
                ret = ret + "\n" + strings[i]; 
            }
            return ret+"\r";
        }

        private void ResetColors()
        {
            ingredientList.BackColor = Color.Empty;
            newAmountText.BackColor = Color.Empty;
            originalPortions.BackColor = Color.Empty;
            newPortions.BackColor = Color.Empty;
        }

        private void Clean()
        {
            ingredientList.Clear();
            newAmountText.Clear();
            originalPortions.Clear();
            newPortions.Clear();
            ResetColors();
            UpdateComboBox();
            radioIngredient.Checked = false;
            radioPortion.Checked = false;
        }

        private void UpdateComboBox()
        {
            if (recipe.GetIngredientCounter() == 0)
            {
                comboBox1.DataSource = null;
            }
            else
            {
                comboBox1.DataSource = recipe.ToStringArray();
            }
        
        }

        private void UncheckRadios(){
            radioIngredient.Checked = false;
            radioPortion.Checked = false;
        }

        private void TextBoxInvalidValue(TextBox tb)
        {
           
            MessageBox.Show(ErrorMessage, ErrorTitle, MessageBoxButtons.OK ,MessageBoxIcon.Error);
            tb.BackColor = Color.Red;
            if (tb == ingredientList)
                UncheckRadios();
        }

        private double TextBoxToDouble(TextBox tb)
        {
            double value;
            try
            {
                value = Double.Parse(Recipe.PointToComma(tb.Text));
                if (value <= 0)
                {
                    throw new FormatException();
                }
            }
            catch (FormatException)
            {
                TextBoxInvalidValue(tb);
                return -1;
            };
            return value;
        }

    }
}
