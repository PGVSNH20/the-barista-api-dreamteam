using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaristaApi.CoffeeService
{
    internal interface ICoffeeMachine
    {
        public ICoffeeMachine AddEspresso();

        public ICoffeeMachine AddMilk();

        public ICoffeeMachine AddMilkFoam();

        public ICoffeeMachine AddChocolateSyrup();

        public ICoffeeMachine AddWater();

        public IBeverage ToBeverage();
    }
}