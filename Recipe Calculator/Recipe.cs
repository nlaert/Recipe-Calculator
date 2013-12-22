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
        private Ingredient[] ingredients;
        private const int ARRAY_GROWTH_INDEX = 5;
        private int arraySize = 15;

        public Recipe()
        {
            ingredientCounter = 0;
            ingredients = new Ingredient[arraySize];
        }

        public void NewIngredient(String ing)
        {
            if (ingredientCounter >= ingredients.Length)
                GrowArray();
            ingredients[ingredientCounter] = ToIngredientList(ing);
            ingredientCounter++;
        }

        public bool CalculatePortions(double origPortion, double newPortion)
        {
            double percent = newPortion / origPortion;
            return Calculate(percent);
        }

        public bool CalculateAmountByIndex(int idx, double newAmount)
        {
            double percent = newAmount / ingredients[idx].GetAmount();
            return Calculate(percent);
        }

        public int GetIngredientCounter()
        {
            return ingredientCounter;
        }

        public String[] ToStringArray()
        {
            String[] recipe = new String[ingredientCounter];
            for (int i = 0; i < ingredientCounter; i++)
            {
                recipe[i] = ingredients[i].ToString();
            }
            return recipe;
        }

        private bool Calculate(double percent)
        {
            if (ingredientCounter == 0)
                return false;
            for (int i = 0; i < ingredientCounter; i++)
            {
                if (ingredients[i].HasAmount())
                {
                    double aux = ingredients[i].GetAmount() * percent;
                    aux = (double)Math.Round(aux * 100);
                    aux = aux / 100;
                    ingredients[i].SetAmount(aux);
                }
            }
            return true;
        }

        private void GrowArray()
        {
            Ingredient[] aux = new Ingredient[ingredients.Length + ARRAY_GROWTH_INDEX];
            Array.Copy(ingredients, aux, ingredientCounter);
            //for (int i = 0; i < ingredientCounter; i++)
            //    aux[i] = ingredient[i];
            ingredients = aux;
            arraySize += ARRAY_GROWTH_INDEX;
        }

        private Ingredient ToIngredientList(String ing) 
        {
            ing.Trim();
            if ((ing[0] != ',' && ing[0]!='.') && (ing[0] < '0' || ing[0] > '9'))
                return new Ingredient(ing);
            ing = PointToComma(ing);
            int space = ing.IndexOf(' ');
            if (space < 0)
            {
                throw new FormatException();
            }
            double a = Double.Parse(ing.Substring(0, space));
            return new Ingredient(a, ing.Substring(space + 1));
        }

        public static String PointToComma(String ing)
        {
            int point = ing.IndexOf('.');
            if (point >= 0)
                ing = ing.Substring(0, point + 1).Replace('.', ',') + ing.Substring(point + 1);
            return ing;
        }
    }
}
