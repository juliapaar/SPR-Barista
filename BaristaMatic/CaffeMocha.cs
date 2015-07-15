using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaristaMatic
{
    /// <summary>
    /// Class for Caffe Mocha
    /// </summary>
    public class CaffeMocha : Drink
    {
        public CaffeMocha()
        {
            this.Name = "Caffee Mocha";
            this.DrinkIngredients = new Dictionary<Ingredient, int>();

            this.DrinkIngredients.Add(IngredientsCollection.ingredients.Single(x => x.Name == "Expresso"), 1);
            this.DrinkIngredients.Add(IngredientsCollection.ingredients.Single(x => x.Name == "Cocoa"), 1);
            this.DrinkIngredients.Add(IngredientsCollection.ingredients.Single(x => x.Name == "Steamed Milk"), 1);
            this.DrinkIngredients.Add(IngredientsCollection.ingredients.Single(x => x.Name == "Whipped Cream"), 1);
        }
    }
}
