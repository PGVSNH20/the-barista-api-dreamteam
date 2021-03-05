using BaristaApi.Ingredients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaristaApi.Beverages
{
    public class CustomDrink : Beverage
    {
        public CustomDrink(List<string> ingridients, Bean bean) : base(ingridients, bean)
        {
        }
    }
}