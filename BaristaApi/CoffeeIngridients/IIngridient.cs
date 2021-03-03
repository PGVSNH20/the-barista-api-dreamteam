using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaristaApi.CoffeIngridients
{
    public interface IIngridient
    {
        public string Name { get; }
        public int AmountInG { get; }
    }
}