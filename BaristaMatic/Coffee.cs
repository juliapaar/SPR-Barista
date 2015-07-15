using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaristaMatic
{
    /// <summary>
    /// Class for Coffee
    /// </summary>
    public class Coffee : Drink
    {
        public Coffee()
        {
            this.Name = "Coffee";
            this.DrinkIngredients = new Dictionary<Ingredient, int>();

            this.DrinkIngredients.Add(IngredientsCollection.ingredients.Single(x => x.Name == "Coffee"), 3);
            this.DrinkIngredients.Add(IngredientsCollection.ingredients.Single(x => x.Name == "Sugar"), 1);
            this.DrinkIngredients.Add(IngredientsCollection.ingredients.Single(x => x.Name == "Cream"), 1);
        }
    }
}
