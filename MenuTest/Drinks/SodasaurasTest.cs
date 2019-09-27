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

        [Fact]
        public void ShouldBeAbleToSetFlavorToOrange()
        {
            Sodasauras soda = new Sodasauras();
            soda.Flavor = SodasaurasFlavor.Orange;
            Assert.Equal<SodasaurasFlavor>(SodasaurasFlavor.Orange, soda.Flavor);
        }

        [Fact]
        public void ShouldBeAbleToSetFlavorToVanilla()
        {
            Sodasauras soda = new Sodasauras();
            soda.Flavor = SodasaurasFlavor.Vanilla;
            Assert.Equal<SodasaurasFlavor>(SodasaurasFlavor.Vanilla, soda.Flavor);
        }

        [Fact]
        public void ShouldBeAbleToSetFlavorToChocolate()
        {
            Sodasauras soda = new Sodasauras();
            soda.Flavor = SodasaurasFlavor.Chocolate;
            Assert.Equal<SodasaurasFlavor>(SodasaurasFlavor.Chocolate, soda.Flavor);
        }

        [Fact]
        public void ShouldBeAbleToSetFlavorToRootBeer()
        {
            Sodasauras soda = new Sodasauras();
            soda.Flavor = SodasaurasFlavor.RootBeer;
            Assert.Equal<SodasaurasFlavor>(SodasaurasFlavor.RootBeer, soda.Flavor);
        }

        [Fact]
        public void ShouldBeAbleToSetFlavorToCherry()
        {
            Sodasauras soda = new Sodasauras();
            soda.Flavor = SodasaurasFlavor.Cherry;
            Assert.Equal<SodasaurasFlavor>(SodasaurasFlavor.Cherry, soda.Flavor);
        }

        [Fact]
        public void ShouldBeAbleToSetFlavorToLime()
        {
            Sodasauras soda = new Sodasauras();
            soda.Flavor = SodasaurasFlavor.Lime;
            Assert.Equal<SodasaurasFlavor>(SodasaurasFlavor.Lime, soda.Flavor);
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
            soda.Size = Size.Medium;
            soda.Size = Size.Small;            
            Assert.Equal<double>(1.50, soda.Price);
        }

        [Fact]
        public void ShouldHaveCorrectPriceForMedium()
        {
            Sodasauras soda = new Sodasauras();
            soda.Size = Size.Medium;
            Assert.Equal<double>(2.00, soda.Price);
        }

        [Fact]
        public void ShouldHaveCorrectPriceForLarge()
        {
            Sodasauras soda = new Sodasauras();
            soda.Size = Size.Large;
            Assert.Equal<double>(2.50, soda.Price);
        }

        [Fact]
        public void ShouldHaveCorrectCaloriesForSmall()
        {
            Sodasauras soda = new Sodasauras();
            soda.Size = Size.Medium;
            soda.Size = Size.Small;
            Assert.Equal<uint>(112, soda.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectCaloriesForMedium()
        {
            Sodasauras soda = new Sodasauras();
            soda.Size = Size.Medium;
            Assert.Equal<uint>(156, soda.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectCaloriesForLarge()
        {
            Sodasauras soda = new Sodasauras();
            soda.Size = Size.Large;
            Assert.Equal<uint>(208, soda.Calories);
        }

        /// The default Ice value should be True.    
        [Fact]
        public void ShouldHaveDefaultIce()
        {
            Sodasauras soda = new Sodasauras();
            Assert.True(soda.Ice);
        }
        ///That invoking HoldIce() results in the Ice property being false.
        [Fact]
        public void ShouldBeAbleToHoldIce()
        {
            Sodasauras soda = new Sodasauras();
            soda.HoldIce();
            Assert.False(soda.Ice);
        }

        ///The sodasauras should have correct ingredients set
        [Fact]
        public void ShouldHaveCorrectIngredients()
        {
            Sodasauras soda = new Sodasauras();
            Assert.Contains<string>("Water", soda.Ingredients);
            Assert.Contains<string>("Natural Flavors", soda.Ingredients);
            Assert.Contains<string>("Cane Sugar", soda.Ingredients);
            Assert.Equal<int>(3, soda.Ingredients.Count);
        }

    }
}
