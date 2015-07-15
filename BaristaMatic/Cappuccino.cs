using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaristaMatic
{
    /// <summary>
    /// Class for Cappuccino
    /// </summary>
    public class Cappuccino : Drink
    {
        public Cappuccino()
        {
            this.Name = "Cappuccino";
            this.DrinkIngredients = new Dictionary<Ingredient, int>();

            this.DrinkIngredients.Add(IngredientsCollection.ingredients.Single(x => x.Name == "Expresso"), 2);
            this.DrinkIngredients.Add(IngredientsCollection.ingredients.Single(x => x.Name == "Steamed Milk"), 1);
            this.DrinkIngredients.Add(IngredientsCollection.ingredients.Single(x => x.Name == "Foamed Milk"), 1);
        }
    }
}
