using BaristaApi.CoffeIngridients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaristaApi.CoffeeService
{
    public interface ICoffeeService
    {
        public Ingridient GenerateIngrident(string name, int amount);

        public ICoffeeService AddEspresso(int amount);

        public ICoffeeService AddMilk(int amount);

        public ICoffeeService AddMilkFoam(int amount);

        public ICoffeeService AddChocolateSyrup(int amount);

        public ICoffeeService AddWater(int amount);

        public ICoffeeService AddBeans(Func<Beans, Beans> choseBeans);

        public ICoffee ToBeverege();
    }
}