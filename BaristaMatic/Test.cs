using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BaristaMatic
{
    /// <summary>
    /// Test Class for the BaristaMatic project
    /// </summary>
    [TestClass]
    public class Test
    {
        [TestMethod]
        public void TestDrinks()
        {
            Coffee coffee = new Coffee();
            Assert.AreEqual("Coffee", coffee.Name, "Invalid name for Coffee Object");
            Assert.AreEqual(3, coffee.DrinkIngredients.Count, "Invalid number of ingredients for Coffee.");

            CaffeAmericano caffeAmericano = new CaffeAmericano();
            Assert.AreEqual("Caffe Americano", caffeAmericano.Name, "Invalid name for Caffe Americano.");
            Assert.AreEqual(1, caffeAmericano.DrinkIngredients.Count, "Invalid number of ingredients for Caffe Americano");

            CaffeLatte caffeLatte = new CaffeLatte();
            Assert.AreEqual("Caffee Latte", caffeLatte.Name, "Invalid name for Caffe Latte.");
            Assert.AreEqual(2, caffeLatte.DrinkIngredients.Count, "Invalid number of ingredients for Caffe Latte");

            CaffeMocha caffeMocha = new CaffeMocha();
            Assert.AreEqual("Caffee Mocha", caffeMocha.Name, "Invalid name for Caffe Mocha.");
            Assert.AreEqual(4, caffeMocha.DrinkIngredients.Count, "Invalid number of ingredients forCaffee Mocha");

            Cappuccino cappuccino = new Cappuccino();
            Assert.AreEqual("Cappuccino", cappuccino.Name, "Invalid name for cappuccino.");
            Assert.AreEqual(3, cappuccino.DrinkIngredients.Count, "Invalid number of ingredients for cappuccino");

            DecafCoffee decafCoffee = new DecafCoffee();
            Assert.AreEqual("Decaf Coffee", decafCoffee.Name, "Invalid name for Decaf Coffee.");
            Assert.AreEqual(3, decafCoffee.DrinkIngredients.Count, "Invalid number of ingredients for Decaf Coffee");
        }

        [TestMethod]
        public void TestInventory()
        {
            IngredientsCollection.RestockInventory();
            Ingredient sugar = IngredientsCollection.ingredients.Single(x => x.Name == "Sugar");
            Assert.IsNotNull(sugar, "Ingredient Sugar should not be null");

            Ingredient cocoa = IngredientsCollection.ingredients.Single(x => x.Name == "Cocoa");
            Assert.IsNotNull(cocoa, "Ingredient Cocoa should not be null");

            Assert.AreEqual(10, cocoa.Quantity, "Invalid quantity for ingredient object after restocking");
        }

        [TestMethod]
        public void TestDrinksCollection()
        {
            DrinksCollection dc = new DrinksCollection();
            List<Drink> lstDrinks = dc.Drinks.ToList();
            Assert.AreEqual(6, lstDrinks.Count, "Invalid number of drinks in the collection");
        }
    }
}
