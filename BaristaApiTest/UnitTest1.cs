using System;
using Xunit;

namespace BaristaApiTest
{
    public class UnitTest1
    {
        [Fact]
        public void When_AddingBeans_GridningBeans_()
        {
            var beverage = new CoffeeService.CoffeeService()
                .AddBeans(b => { b.AmountInG = 100; b.Sort = "Robusta"; return b; })
                .GrindBeans()
                .AddEspresso(200)
                .ToBeverege();
            Assert.IsType<Espresso>(beverage);
        }
    }
}