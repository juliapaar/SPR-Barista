using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaristaMatic
{
    /// <summary>
    /// Class for Decaf Coffee
    /// </summary>
    class DecafCoffee : Drink
    {
        public DecafCoffee()
        {
            this.Name = "Decaf Coffee";
            this.DrinkIngredients = new Dictionary<Ingredient, int>();

            this.DrinkIngredients.Add(IngredientsCollection.ingredients.Single(x => x.Name == "Decaf Coffee"), 3);
            this.DrinkIngredients.Add(IngredientsCollection.ingredients.Single(x => x.Name == "Sugar"), 1);
            this.DrinkIngredients.Add(IngredientsCollection.ingredients.Single(x => x.Name == "Cream"), 1);
        }
    }
}
