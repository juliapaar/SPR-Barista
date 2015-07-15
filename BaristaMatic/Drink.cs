using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaristaMatic
{
    public class Drink
    {
        public Drink()
        {
        }

        public Drink(string name)
        {
            this.name = name;
        }

        public string Name {
            get { return name; }
            set { name = value; }
        }

        public Dictionary<Ingredient, int> DrinkIngredients
        {
            get { return drinkIngredient; }
            set { drinkIngredient = value; }
        }

        /// <summary>
        /// Determine the cost of each drink
        /// </summary>
        public double DrinkCost
        {
            get
            {
                double dCost = 0.0;
                foreach (KeyValuePair<Ingredient, int> ingredient in DrinkIngredients)
                {
                    dCost = dCost + ingredient.Key.UnitCost * ingredient.Value;
                }

                return dCost;
            }
        }

        /// <summary>
        /// Determine if the drink is in stock or not
        /// </summary>
        public bool InStock
        {
            get
            {
                foreach (KeyValuePair<Ingredient, int> ingredient in DrinkIngredients)
                {
                    if (ingredient.Key.Quantity < ingredient.Value)
                    {
                        return false;
                    }
                }

                return true;
            }
        }

        /// <summary>
        /// Update the inventory after a drink has been purchased.
        /// </summary>
        public void UpdateInventory()
        {
            foreach (KeyValuePair<Ingredient, int> ingredient in DrinkIngredients)
            {
                Ingredient ig = IngredientsCollection.ingredients.Single(x => x.Name == ingredient.Key.Name);
                ig.Quantity = ig.Quantity - ingredient.Value;
            }
        }

        private string name;
        private Dictionary<Ingredient, int> drinkIngredient;
    }
}
