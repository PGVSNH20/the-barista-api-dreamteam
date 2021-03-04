using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaristaApi.Beverages
{
    public class Espresso : Beverage
    {
        public static List<string> recipe = new List<string>()
        {
            "Espresso"
        };
        public Espresso(List<string> ingridients) : base(ingridients)
        {
            
        }
    }
}