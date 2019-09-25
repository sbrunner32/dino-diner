using System;
using System.Collections.Generic;
using System.Text;

using Xunit;
using DinoDiner.Menu;
using DinoDiner.Menu.Drinks;

namespace MenuTest.Drinks
{
    public class SodasaurasTest
    {
        ///The ability to set each possible flavor
        [Fact]
        public void ShouldBeAbleToSetFlavorToCola()
        {
            Sodasauras soda = new Sodasauras();
            soda.Flavor = SodasaurasFlavor.Cola;
            Assert.Equal<SodasaurasFlavor>(SodasaurasFlavor.Cola, soda.Flavor);
        }
        ///The correct default price, calories, ice, and size
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            Sodasauras soda = new Sodasauras();
            Assert.Equal<double>(1.50, soda.Price);
        }
        ///The correct price and calories after changing to small, medium, and large sizes.
        [Fact]
        public void ShouldHaveCorrectPriceForSmall()
        {
            Sodasauras soda = new Sodasauras();
            soda.Size = Size.Small;            
            Assert.Equal<double>(1.50, soda.Price);
        }

        [Fact]
        public void ShouldHaveDefaultIce()
        {
            Sodasauras soda = new Sodasauras();
            Assert.True(soda.Ice);
        }
        ///That invoking HoldIce() results in the Ice property being false.

    }
}
