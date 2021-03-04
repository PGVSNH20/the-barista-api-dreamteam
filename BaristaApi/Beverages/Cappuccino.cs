using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaristaApi.Beverages
{
    internal class Cappuccino : Beverage
    {
        public static List<string> recipe = new List<string>()
        {
            "Espresso",
            "Milk",
            "Milk Foam"
        };

        public Cappuccino(List<string> ingridients) : base(ingridients)
        {
        }
    }
}