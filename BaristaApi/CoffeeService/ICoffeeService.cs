using BaristaApi.CoffeeTypes;
using System;

namespace BaristaApi.CoffeeService
{
    public interface ICoffeeService
    {
        public Ingridient GenerateIngrident(string name, int amount);

        public ICoffeeService AddEspresso();

        public ICoffeeService AddMilk(int amount);

        public ICoffeeService AddMilkFoam(int amount);

        public ICoffeeService AddChocolateSyrup(int amount);

        public ICoffeeService AddWater(int amount);

        public ICoffeeService AddBeans(Func<Beans, Beans> choseBeans);

        public ICoffeeService GrindBeans();

        public ICoffee ToBeverege();
    }
}