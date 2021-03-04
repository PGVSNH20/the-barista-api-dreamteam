using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaristaApi.Beverages
{
    internal class Americano : Beverage
    {
        public static List<string> recipe = new List<string>()
        {
            "Espresso",
            "Water"
        };

        public Americano(List<string> ingridients) : base(ingridients)
        {
        }
    }
}
