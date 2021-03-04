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
    }
}