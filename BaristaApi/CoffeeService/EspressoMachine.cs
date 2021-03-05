using BaristaApi.CoffeeIngridients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaristaApi.CoffeeService
{
    public class EspressoMachine : IEspressoMachine
    {
        public Beans Beans { get; set; }

        public EspressoMachine()
        {
            Beans = new Beans();
        }

        public IEspressoMachine AddBeans(Func<Beans, Beans> defineBeans)
        {
            Beans = defineBeans(Beans);
            return this;
        }

        public MilkFoam FoamMilk(Milk milk)
        {
            return new MilkFoam(milk);
        }

        public IEspressoMachine GrindBeans()
        {
            if (Beans.AmountInG > 0) Beans.Grinded = true;
            else throw new Exception("No Beans added!");
            return this;
        }

        public EspressoIngr MakeEspresso()
        {
            if (Beans.AmountInG <= 0) throw new Exception("No Beans added!");
            else if (Beans.Grinded == false) throw new Exception("Beans not grind!");
            var water = new Water(Beans.AmountInG * 3);
            return new EspressoIngr(water.AmountInG, Beans.Sort);
        }
    }
}