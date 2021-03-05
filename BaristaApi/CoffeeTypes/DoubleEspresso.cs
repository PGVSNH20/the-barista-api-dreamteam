using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaristaApi.CoffeeTypes
{
    public class DoubleEspresso : Coffee
    {
        public DoubleEspresso(ICoffee beverage) : base(beverage)
        {
        }
    }
}