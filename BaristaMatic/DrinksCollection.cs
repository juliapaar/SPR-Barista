using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaristaMatic
{
    /// <summary>
    /// Class to initialize a collection of all drinks
    /// </summary>
    public class DrinksCollection
    {
        private  Drink[] drinks = new Drink[] {
              new Coffee(),
                new CaffeLatte(),
                new CaffeAmericano(),
                new Cappuccino(),
                new DecafCoffee(),
                new CaffeMocha() 
        };

        public Drink[] Drinks
        {
            get
            {
                List<Drink> lstDrink = drinks.ToList();
                return lstDrink.OrderBy(s => s.Name).ToArray();
            }
        }
    }
}
