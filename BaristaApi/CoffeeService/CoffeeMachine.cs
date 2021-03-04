using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaristaApi.CoffeeService
{
    public class CoffeeMachine : IBeverage, ICoffeeMachine
    {
        public List<string> Ingredients { get; set; }
        public string CupType { get; set; }

        public ICoffeeMachine AddChocolateSyrup()
        {
            throw new NotImplementedException();
        }

        public ICoffeeMachine AddEspresso()
        {
            throw new NotImplementedException();
        }

        public ICoffeeMachine AddMilk()
        {
            throw new NotImplementedException();
        }

        public ICoffeeMachine AddMilkFoam()
        {
            throw new NotImplementedException();
        }

        public ICoffeeMachine AddWater()
        {
            throw new NotImplementedException();
        }
    }
}