using BaristaApi.CoffeIngridients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaristaApi.CoffeeTypes
{
    internal class UnknowBeverage : ICoffee
    {
        public List<IIngridient> Ingredients { get; set; }
        public string CupType { get; set; }
        public Beans Beans { get; set; }

        public UnknowBeverage(ICoffee beverage)
        {
            Ingredients = beverage.Ingredients;
            CupType = beverage.CupType;
            Beans = beverage.Beans;
        }
    }
}