using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaristaApi.CoffeIngridients
{
    public class Espresso : Ingridient
    {
        public Espresso(Ingridient ingrident)
        {
            Name = ingrident.Name;
            AmountInG = ingrident.AmountInG;
        }

        public Espresso(int amountIng)
        {
            Name = "Espresso";
            AmountInG = amountIng;
        }
    }
}