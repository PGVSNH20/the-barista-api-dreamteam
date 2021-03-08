using BaristaApi.Ingredients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaristaApi.Beverages
{
    public class Americano : Beverage
    {
        public static List<string> recipe = new List<string>()
        {
            "Espresso",
            "Water"
        };

        public Americano(List<string> ingridients, Bean bean) : base(ingridients, bean)
        {
        }

        public override void PrintBeverageTag()
        {
            Console.WriteLine("This beverage is an Americano");
        }
    }
}
