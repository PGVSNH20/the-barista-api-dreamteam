using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaristaApi.Beverages
{
    public class Mocha : Beverage
    {
        public static List<string> recipe = new List<string>()
        {
            "Espresso",
            "Chocolate Syrup",
            "Milk"
        };
        public Mocha(List<string> ingridients) : base(ingridients)
        {

        }
    }
}
