using Xunit;

namespace BaristaApi.Tests
{
    public class FluentApiTests
    {
        [Fact]
        public void Expect_Espresso()
        {
            var beverage = new CoffeeService.CoffeeService()
                .AddBeans(b => { b.AmountInG = 10; b.Sort = "Robusta"; return b; })
                .GrindBeans()
                .AddEspresso()
                .ToBeverege();
            Assert.IsType<CoffeeTypes.Espresso>(beverage);
        }

        [Fact]
        public void Expect_DoubleEspresso()
        {
            var beverage = new CoffeeService.CoffeeService()
                .AddBeans(b => { b.AmountInG = 20; b.Sort = "Robusta"; return b; })
                .GrindBeans()
                .AddEspresso()
                .ToBeverege();
            Assert.IsType<CoffeeTypes.DoubleEspresso>(beverage);
        }

        [Fact]
        public void Expect_Americano()
        {
            var beverage = new CoffeeService.CoffeeService()
                .AddBeans(b => { b.AmountInG = 20; b.Sort = "Robusta"; return b; })
                .GrindBeans()
                .AddEspresso()
                .AddWater(60)
                .ToBeverege();
            Assert.IsType<CoffeeTypes.Americano>(beverage);
        }

        [Fact]
        public void Expect_Cappuccino()
        {
            var beverage = new CoffeeService.CoffeeService()
                .AddBeans(b => { b.AmountInG = 20; b.Sort = "Robusta"; return b; })
                .GrindBeans()
                .AddEspresso()
                .AddMilkFoam(100)
                .AddMilk(50)
                .ToBeverege();
            Assert.IsType<CoffeeTypes.Cappuccino>(beverage);
        }

        [Fact]
        public void Expect_Macchiato()
        {
            var beverage = new CoffeeService.CoffeeService()
                .AddBeans(b => { b.AmountInG = 20; b.Sort = "Robusta"; return b; })
                .GrindBeans()
                .AddEspresso()
                .AddMilkFoam(150)
                .ToBeverege();
            Assert.IsType<CoffeeTypes.Macchiato>(beverage);
        }

        [Fact]
        public void Expect_Mocha()
        {
            var beverage = new CoffeeService.CoffeeService()
                .AddBeans(b => { b.AmountInG = 20; b.Sort = "Robusta"; return b; })
                .GrindBeans()
                .AddEspresso()
                .AddMilk(150)
                .AddChocolateSyrup(50)
                .ToBeverege();
            Assert.IsType<CoffeeTypes.Mocha>(beverage);
        }

        [Fact]
        public void Expect_Latte()
        {
            var beverage = new CoffeeService.CoffeeService()
                .AddBeans(b => { b.AmountInG = 20; b.Sort = "Robusta"; return b; })
                .GrindBeans()
                .AddEspresso()
                .AddMilk(150)
                .ToBeverege();
            Assert.IsType<CoffeeTypes.Latte>(beverage);
        }
    }
}