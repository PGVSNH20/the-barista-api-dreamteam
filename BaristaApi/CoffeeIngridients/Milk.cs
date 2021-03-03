using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaristaApi.CoffeIngridients
{
    internal class Milk : IIngridient
    {
        public string Name { get; set; } = "Milk";
        public int AmountInG { get; set; }
        public string FatPercentage { get; set; }
    }
}