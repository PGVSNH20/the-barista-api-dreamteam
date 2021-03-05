using BaristaApi.CoffeeIngridients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaristaApi.CoffeeService
{
    public interface IEspressoMachine
    {
        public Beans Beans { get; }

        public IEspressoMachine AddBeans(Func<Beans, Beans> choseBeans);

        public IEspressoMachine GrindBeans();

        public EspressoIngr MakeEspresso();

        public MilkFoam FoamMilk(Milk milk);
    }
}