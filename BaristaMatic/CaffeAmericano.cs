using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaristaMatic
{
    /// <summary>
    /// Class for Caffe Americano 
    /// </summary>
    public class CaffeAmericano : Drink
    {
        public CaffeAmericano()
        {
            this.Name = "Caffe Americano";
            this.DrinkIngredients = new Dictionary<Ingredient, int>();

            this.DrinkIngredients.Add(IngredientsCollection.ingredients.Single(x => x.Name == "Expresso"), 3);
        }
    }
}
