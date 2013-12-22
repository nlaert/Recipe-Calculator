using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recipe_Calculator
{
    class Recipe
    {
        private int ingredientCounter;
        private Ingredient[] ingredient;
        private const int ARRAY_GROWTH_INDEX = 5;

        public Recipe()
        {
            ingredientCounter = 0;
            ingredient = new Ingredient[15];
        }

        public void newIngredient(String ing)
        {
            if (ingredientCounter >= ingredient.Length)
                growArray();
            ingredient[ingredientCounter++] = toIngredientList(ing);
        }

        public bool calculatePortions(double origPortion, double newPortion)
        {
            double percent = newPortion / origPortion;
            return calculate(percent);
        }

        public bool calculateAmountByIndex(int idx, double newAmount)
        {
            double percent = newAmount / ingredient[idx].getAmount();
            return calculate(percent);
        }

        public int getIngredientCounter()
        {
            return ingredientCounter;
        }

        public String[] toStringArray()
        {
            String[] recipe = new String[ingredientCounter];
            for (int i = 0; i < ingredientCounter; i++)
            {
                recipe[i] = ingredient[i].toString()+"\n";
            }
            return recipe;
        }

        private bool calculate(double percent)
        {
            if (ingredientCounter == 0)
                return false;
            for (int i = 0; i < ingredientCounter; i++)
            {
                double aux = ingredient[i].getAmount() * percent;
                aux = (double)Math.Round(aux * 100);
                aux = aux / 100;
                ingredient[i].setAmount(aux);
            }
            return true;
        }

        private void growArray()
        {
            Ingredient[] aux = new Ingredient[ingredient.Length + ARRAY_GROWTH_INDEX];
            Array.Copy(ingredient, aux, ingredientCounter);
            //for (int i = 0; i < ingredientCounter; i++)
            //    aux[i] = ingredient[i];
            ingredient = aux;
        }

        private Ingredient toIngredientList(String ing)
        {
            ing.Trim();
            int space = ing.IndexOf(' ');
            double a = Double.Parse(ing.Substring(0, space));
            return new Ingredient(a, ing.Substring(space + 1));
        }	
    }
}
