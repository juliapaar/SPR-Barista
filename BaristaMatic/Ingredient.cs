using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaristaMatic
{
    public class Ingredient
    {
        public string Name { get; set; }
        public double UnitCost { get; set; }
        public int Quantity { get; set; }

        public override string ToString()
        {
            return Name + ", " + Quantity.ToString();
        }
    }
}
