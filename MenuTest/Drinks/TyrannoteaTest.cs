using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using DinoDiner.Menu;
using DinoDiner.Menu.Drinks;

namespace MenuTest.Drinks
{
    public class TyrannoteaTest
    {
        ///The correct default price, calories, ice, and size
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.Equal<double>(0.99, tea.Price);
        }
        /// The default value for calories should be 8
        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.Equal<uint>(8, tea.Calories);
        }

        /// The default Ice value should be True.    
        [Fact]
        public void ShouldHaveDefaultIce()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.True(tea.Ice);
        }

        /// The default Sweet value should be False.    
        [Fact]
        public void ShouldHaveDefaultSweet()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.False(tea.Sweet);
        }

        /// The default Lemon value should be False.    
        [Fact]
        public void ShouldHaveDefaultLemon()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.False(tea.Lemon);
        }

        ///The tyrannotea should have the correct default size of small
        [Fact]
        public void ShouldHaveCorrectDefaultSize()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.Equal<Size>(Size.Small, tea.Size);
        }

        ///The correct price and calories after changing to small, medium, and large sizes.
        [Fact]
        public void ShouldHaveCorrectPriceForSmall()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Medium;
            tea.Size = Size.Small;
            Assert.Equal<double>(0.99, tea.Price);
        }

        [Fact]
        public void ShouldHaveCorrectPriceForMedium()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Medium;
            Assert.Equal<double>(1.49, tea.Price);
        }

        [Fact]
        public void ShouldHaveCorrectPriceForLarge()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Large;
            Assert.Equal<double>(1.99, tea.Price);
        }

        [Fact]
        public void ShouldHaveCorrectCaloriesForSmall()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Medium;
            tea.Size = Size.Small;
            Assert.Equal<uint>(8, tea.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectCaloriesForMedium()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Medium;
            Assert.Equal<uint>(16, tea.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectCaloriesForLarge()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Large;
            Assert.Equal<uint>(32, tea.Calories);
        }

        ///That invoking HoldIce() results in the Ice property being false.
        [Fact]
        public void ShouldBeAbleToHoldIce()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.HoldIce();
            Assert.False(tea.Ice);
        }

        ///That invoking AddLemon() results in the Lemon property being true.
        [Fact]
        public void ShouldBeAbleToAddLemon()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.AddLemon();
            Assert.True(tea.Lemon);
        }

        ///The tyrannotea should have correct default ingredients set
        [Fact]
        public void ShouldHaveCorrectDefaultIngredients()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.Contains<string>("Water", tea.Ingredients);
            Assert.Contains<string>("Tea", tea.Ingredients);
            Assert.Equal<int>(2, tea.Ingredients.Count);
        }

        ///The tyrannotea should have correct ingredients set for all values
        [Fact]
        public void ShouldHaveCorrectIngredients()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Sweet = true;
            tea.AddLemon();
            Assert.Contains<string>("Water", tea.Ingredients);
            Assert.Contains<string>("Tea", tea.Ingredients);
            Assert.Contains<string>("Cane Sugar", tea.Ingredients);
            Assert.Contains<string>("Lemon", tea.Ingredients);
            Assert.Equal<int>(4, tea.Ingredients.Count);
        }

        ///The Tea should have the correct amount of calories when the sweet property is set to true
        [Fact]
        public void ShouldHaveCorrectSweetSmallCalories()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Sweet = true;
            Assert.Equal<uint>(16, tea.Calories);
        }

        ///The Tea should have the correct amount of calories when the sweet property is set to true
        [Fact]
        public void ShouldHaveCorrectSweetMediumCalories()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Medium;
            tea.Sweet = true;
            Assert.Equal<uint>(32, tea.Calories);
        }

        ///The Tea should have the correct amount of calories when the sweet property is set to true
        [Fact]
        public void ShouldHaveCorrectSweetLargeCalories()
        {
            Tyrannotea tea = new Tyrannotea();
            
            tea.Sweet = true;
            tea.Size = Size.Large;
            Assert.Equal<uint>(64, tea.Calories);
        }

        ///The Tea should have the correct amount of calories when the sweet property is set to false after being set to true.
        [Fact]
        public void ShouldHaveCaloriesSwapBackAfterSweetForSmall()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Sweet = true;
            tea.Sweet = false;
            Assert.Equal<uint>(8, tea.Calories);
        }

        ///The Tea should have the correct amount of calories when the sweet property is set to false after being set to true.
        [Fact]
        public void ShouldHaveCaloriesSwapBackAfterSweetForMedium()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Medium;
            tea.Sweet = true;
            tea.Sweet = false;
            Assert.Equal<uint>(16, tea.Calories);
        }

        ///The Tea should have the correct amount of calories when the sweet property is set to false after being set to true.
        [Fact]
        public void ShouldHaveCaloriesSwapBackAfterSweetForLarge()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Large;
            tea.Sweet = true;
            tea.Sweet = false;

            Assert.Equal<uint>(32, tea.Calories);
        }


    }
}
