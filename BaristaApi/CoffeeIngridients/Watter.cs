using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaristaApi.CoffeIngridients
{
    internal class Watter : IIngridient
    {
        public string Name { get; set; }
        public int AmountInG { get; set; }
        public int Temperature { get; set; }
    }
}