using BaristaApi.Beverages;
using BaristaApi.Ingredients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaristaApi.CoffeeService
{
    public interface ICoffeeMachine

    {
        public delegate Bean BeanDelegate(Bean bean);

        public ICoffeeMachine AddEspresso();

        public ICoffeeMachine AddMilk();

        public ICoffeeMachine AddMilkFoam();

        public ICoffeeMachine AddChocolateSyrup();

        public ICoffeeMachine AddWater();

        public ICoffeeMachine AddCustom(string ingredient);

        public ICoffeeMachine AddBean(string sort, int amount);

        //public ICoffeeMachine AddBean(Func<Bean, Bean> beanFunc);

        public ICoffeeMachine AddBean(BeanDelegate beanFunc);

        public IBeverage ToBeverage();
    }
}