using BaristaApi.Beverages;
using BaristaApi.CoffeeService;
using Xunit;

namespace BaristaApi.Tests
{
    public class FluentApiTests
    {
        [Fact]
        public void When_AddEspresso_Expect_Espresso()
        {
            var beverage = new CoffeeMachine().AddEspresso().ToBeverage();
            Assert.IsType<Espresso>(beverage);
        }

        [Fact]
        public void When_AddEspressoMilk_Expect_Latte()
        {
            var beverage = new CoffeeMachine().AddEspresso().AddMilk().ToBeverage();
            Assert.IsType<Latte>(beverage);
        }

        [Fact]
        public void When_AddEspressoMilkSyrup_Expect_Mocha()
        {
            var beverage = new CoffeeMachine().AddEspresso().AddChocolateSyrup().AddMilk().ToBeverage();
            Assert.IsType<Mocha>(beverage);
        }

        [Fact]
        public void When_AddEspressoWater_Expect_Americano()
        {
            var beverage = new CoffeeMachine().AddEspresso().AddWater().ToBeverage();
            Assert.IsType<Americano>(beverage);
        }

        [Fact]
        public void When_AddEspressoMilkFoam_Expect_Macchiato()
        {
            var beverage = new CoffeeMachine().AddEspresso().AddMilkFoam().ToBeverage();
            Assert.IsType<Macchiato>(beverage);
        }

        [Fact]
        public void When_AddEspresso_Milk_MilkFoam_Expect_Cappuchino()
        {
            var beverage = new CoffeeMachine().AddEspresso().AddMilk().AddMilkFoam().ToBeverage();
            Assert.IsType<Cappuccino>(beverage);
        }

        [Fact]
        public void When_AddMilk_Expect_CustomDrink()
        {
            var beverage = new CoffeeMachine().AddMilk().ToBeverage();
            Assert.IsType<CustomDrink>(beverage);
        }
    }
}