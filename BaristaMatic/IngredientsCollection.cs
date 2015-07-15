using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaristaMatic
{
    public static class IngredientsCollection
    {
        public static List<Ingredient> ingredients = new List<Ingredient>()
            {
                new Ingredient {Name = "Coffee", UnitCost = 0.75},
                new Ingredient {Name = "Decaf Coffee", UnitCost = 0.75},
                new Ingredient {Name = "Sugar", UnitCost = 0.25},
                new Ingredient {Name = "Cream", UnitCost = 0.25},
                new Ingredient {Name = "Steamed Milk", UnitCost = 0.35},
                new Ingredient {Name = "Foamed Milk", UnitCost = 0.35},
                new Ingredient {Name = "Expresso", UnitCost = 1.10},
                new Ingredient {Name = "Cocoa", UnitCost = 0.90},
                new Ingredient {Name = "Whipped Cream", UnitCost = 1.00},
            }.OrderBy(s => s.Name).ToList();

        public static void RestockInventory()
        {
            foreach (Ingredient item in ingredients)
            {
                item.Quantity = 10;
            }
        }
    }
}
