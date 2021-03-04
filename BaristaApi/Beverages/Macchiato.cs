using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaristaApi.Beverages
{
    public class Macchiato : Beverage
    {
        public static List<string> recipe = new List<string>()
        {
            "Espresso",
            "Milk Foam"

        };
        public Macchiato(List<string> ingridients) : base(ingridients)
        {

        }
    }
}
