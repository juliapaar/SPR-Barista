using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaristaMatic
{
    public class Program
    {      
        static void Main(string[] args)
        {
            IngredientsCollection.RestockInventory();
            DisplayInventory();

            DrinksCollection drinksColl = new DrinksCollection();
            DisplayMenu(drinksColl.Drinks);

            string readValue = Console.ReadLine();
            while (!string.IsNullOrEmpty(readValue)) 
            {
                switch (readValue)
                {
                    case "r":
                    case "R":
                        IngredientsCollection.RestockInventory();
                        DisplayInventory();
                        DisplayMenu(drinksColl.Drinks);
                        break;
                    case "q":
                    case "Q":
                        return;
                    case "1":
                    case "2":
                    case "3":
                    case "4":
                    case "5":
                    case "6":
                        Drink drinkClass = drinksColl.Drinks[Convert.ToInt16(readValue) - 1];
                        if (drinkClass.InStock)
                        {
                            Console.WriteLine(string.Format("Dispensing {0}", drinkClass.Name));
                            drinkClass.UpdateInventory();
                        }
                        else
                        {
                            Console.WriteLine("Out of Stock {0}", drinkClass.Name);
                        }

                        DisplayInventory();
                        DisplayMenu(drinksColl.Drinks);
                        break;
                    default:
                        Console.WriteLine("Invalid Selection {0}", readValue.ToString());
                        break;
                }

                readValue = Console.ReadLine();
            }
        }

        /// <summary>
        /// Method that displays the inventory on the screen
        /// </summary>
        public static void DisplayInventory()
        {
            Console.WriteLine("Inventory:");
            foreach (Ingredient item in IngredientsCollection.ingredients)
            {
                Console.WriteLine(item.ToString());
            }
        }

        /// <summary>
        /// Method that displays the menu on the screen
        /// </summary>
        /// <param name="drinksColl"></param>
        public static void DisplayMenu(Drink[] drinksColl)
        {
            Console.WriteLine("Menu:");
            for (int i = 0; i < drinksColl.Length; i++)
            {
               Console.WriteLine(string.Format("{0}. {1}, {2:C2}, {3}", i+1, drinksColl[i].Name, drinksColl[i].DrinkCost, drinksColl[i].InStock.ToString()));
            }
        }
    }
}
