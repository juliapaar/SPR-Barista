using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaristaMatic
{
    /// <summary>
    /// Class for Caffe Latte
    /// </summary>
    public class CaffeLatte : Drink
    {
        public CaffeLatte()
        {
            this.Name = "Caffee Latte";
            this.DrinkIngredients = new Dictionary<Ingredient, int>();

            this.DrinkIngredients.Add(IngredientsCollection.ingredients.Single(x => x.Name == "Expresso"), 2);
            this.DrinkIngredients.Add(IngredientsCollection.ingredients.Single(x => x.Name == "Steamed Milk"), 1);
        }
    }
}
