using BaristaApi.CoffeeIngridients;
using System.Collections.Generic;

namespace BaristaApi.CoffeeTypes
{
    public interface ICoffee
    {
        public List<IIngridient> Ingredients { get; }
        public string CupType { get; }
    }
}