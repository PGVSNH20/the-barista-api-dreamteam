using BaristaApi.Ingredients;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaristaApi.Beverages
{
    public class Beverage : IBeverage
    {
        public List<string> Ingredients { set; get; }
     
        public string CupType { set; get; }

        public Bean Bean { get; set; }

        public virtual void PrintBeverageTag()
        {
            Console.WriteLine("Some beverage");
        }

        public Beverage(List<string> ingredients, Bean bean)
        {
            Ingredients = ingredients;
            Bean = bean;
        }
    }
}