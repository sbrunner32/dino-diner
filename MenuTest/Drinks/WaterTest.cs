using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using DinoDiner.Menu;
using DinoDiner.Menu.Drinks;

namespace MenuTest.Drinks
{
    public class WaterTest
    {
        ///The correct default price value should be set
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            Water water = new Water();
            Assert.Equal<double>(0.10, water.Price);
        }

        /// The default Ice value should be True.    
        [Fact]
        public void ShouldHaveDefaultIce()
        {
            Water water = new Water();
            Assert.True(water.Ice);
        }

        /// The default Size should be small
        [Fact]
        public void ShouldHaveCorrectDefaultSize()
        {
            Water water = new Water();
            Assert.Equal<Size>(Size.Small, water.Size);
        }

        ///The default calories should be 0
        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            Water water = new Water();
            Assert.Equal<uint>(0, water.Calories);
        }

        /// The default Lemon value should be True.    
        [Fact]
        public void ShouldHaveDefaultLemon()
        {
            Water water = new Water();
            Assert.False(water.Lemon);
        }

        ///The price should change accordingly when the Size is changed to small
        [Fact]
        public void ShouldHaveCorrectSmallPrice()
        {
            Water water = new Water();
            water.Size = Size.Medium;
            water.Size = Size.Small;
            Assert.Equal<double>(0.10, water.Price);
        }

        ///The price should change accordingly when the Size is changed to Medium
        [Fact]
        public void ShouldHaveCorrectMediumPrice()
        {
            Water water = new Water();
            water.Size = Size.Medium;
            Assert.Equal<double>(0.10, water.Price);
        }

        ///The price should change accordingly when the Size is changed to Large
        [Fact]
        public void ShouldHaveCorrectLargePrice()
        {
            Water water = new Water();
            water.Size = Size.Large;
            Assert.Equal<double>(0.10, water.Price);
        }

        ///The calories should change accordingly when the Size is changed to Small
        [Fact]
        public void ShouldHaveCorrectSmallCalories()
        {
            Water water = new Water();
            water.Size = Size.Medium;
            water.Size = Size.Small;
            Assert.Equal<uint>(0, water.Calories);
        }

        ///The calories should change accordingly when the Size is changed to Medium
        [Fact]
        public void ShouldHaveCorrectMediumCalories()
        {
            Water water = new Water();
            water.Size = Size.Medium;
            Assert.Equal<uint>(0, water.Calories);
        }

        ///The calories should change accordingly when the Size is changed to Large
        [Fact]
        public void ShouldHaveCorrectLargeCalories()
        {
            Water water = new Water();
            water.Size = Size.Large;
            Assert.Equal<uint>(0, water.Calories);
        }

        ///That invoking HoldIce() results in the Ice property being false.
        [Fact]
        public void ShouldBeAbleToHoldIce()
        {
            Water water = new Water();
            water.HoldIce();
            Assert.False(water.Ice);
        }

        ///That invoking AddLemon() results in the Lemon property being true.
        [Fact]
        public void ShouldBeAbleToAddLemon()
        {
            Water water = new Water();
            water.AddLemon();
            Assert.True(water.Lemon);
        }

        ///The Water should have the correct Default ingredients set
        [Fact]
        public void ShouldHaveCorrectDefaultIngredients()
        {
            Water water = new Water();
            Assert.Contains<string>("Water", water.Ingredients);     
            Assert.Equal<int>(1, water.Ingredients.Count);
        }

        ///The Water should be able to use AddLemon to add Lemon to the ingredients
        [Fact]
        public void ShouldHaveCorrectIngredients()
        {
            Water water = new Water();
            water.AddLemon();
            Assert.Contains<string>("Water", water.Ingredients);
            Assert.Contains<string>("Lemon", water.Ingredients);
            Assert.Equal<int>(2, water.Ingredients.Count);
        }
    }
}
