using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaristaApi.Beverages
{
    public class Beverage : IBeverage
    {
        public List<string> Ingredients { set; get; }

        public string CupType { set; get; }

        public Beverage(List<string> ingredients)
        {
            Ingredients = ingredients;
        }
    }
}