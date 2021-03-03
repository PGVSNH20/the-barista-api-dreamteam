using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaristaApi.CoffeIngridients
{
    public class MilkFoam : Ingridient
    {
        public string FatPercentage { get; set; }

        public MilkFoam(Ingridient ingrident)
        {
            Name = ingrident.Name;
            AmountInG = ingrident.AmountInG;
        }

        public MilkFoam(int amountIng)
        {
            Name = "Milk Foam";
            AmountInG = amountIng;
            FatPercentage = "1,5%";
        }
    }
}