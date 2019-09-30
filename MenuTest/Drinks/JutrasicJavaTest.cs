using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using DinoDiner.Menu;
using DinoDiner.Menu.Drinks;

namespace MenuTest.Drinks
{
    public class JutrasicJavaTest
    {
        ///The correct default price value should be set
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            JurrasicJava java = new JurrasicJava();
            Assert.Equal<double>(0.59, java.Price);
        }

        /// The default Ice value should be False.    
        [Fact]
        public void ShouldHaveDefaultIce()
        {
            JurrasicJava java = new JurrasicJava();
            Assert.False(java.Ice);
        }

        /// The default Size should be small
        [Fact]
        public void ShouldHaveCorrectDefaultSize()
        {
            JurrasicJava java = new JurrasicJava();
            Assert.Equal<Size>(Size.Small, java.Size);
        }

        ///The default calories should be 2
        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            JurrasicJava java = new JurrasicJava();
            Assert.Equal<uint>(2, java.Calories);
        }

        ///The correct default RoomForCream value is set to false
        [Fact]
        public void ShouldHaveCorrectDefaultRoomForCream()
        {
            JurrasicJava java = new JurrasicJava();
            Assert.False(java.RoomForCream);
        }

        ///The price should change accordingly when the size changes to small
        [Fact]
        public void ShouldHaveCorrectSmallPrice()
        {
            JurrasicJava java = new JurrasicJava();
            java.Size = Size.Medium;
            java.Size = Size.Small;
            Assert.Equal<double>(0.59, java.Price);
        }

        ///The price should change accordingly when the size changes to medium
        [Fact]
        public void ShouldHaveCorrectMediumPrice()
        {
            JurrasicJava java = new JurrasicJava();
            java.Size = Size.Medium;   
            Assert.Equal<double>(0.99, java.Price);
        }

        ///The price should change accordingly when the size changes to Large
        [Fact]
        public void ShouldHaveCorrectLargePrice()
        {
            JurrasicJava java = new JurrasicJava();
            java.Size = Size.Large;
            Assert.Equal<double>(1.49, java.Price);
        }

        ///The calories should adjust accordingly when the size changes to small
        [Fact]
        public void ShouldHaveCorrectSmallCalories()
        {
            JurrasicJava java = new JurrasicJava();
            java.Size = Size.Medium;
            java.Size = Size.Small;
            Assert.Equal<uint>(2, java.Calories);
        }

        ///The calories should adjust accordingly when the size changes to medium
        [Fact]
        public void ShouldHaveCorrectMediumCalories()
        {
            JurrasicJava java = new JurrasicJava();
            java.Size = Size.Medium;     
            Assert.Equal<uint>(4, java.Calories);
        }

        ///The calories should adjust accordingly when the size changes to large
        [Fact]
        public void ShouldHaveCorrectLargeCalories()
        {
            JurrasicJava java = new JurrasicJava();
            java.Size = Size.Large;
            Assert.Equal<uint>(8, java.Calories);
        }

        ///That invoking AddIce() results in the Ice property being true.
        [Fact]
        public void ShouldBeAbleToHoldIce()
        {
            JurrasicJava java = new JurrasicJava();
            java.AddIce();
            Assert.True(java.Ice);
        }


        ///That invoking LeaveRoomForCream() results in the RoomForCream property being true.
        [Fact]
        public void ShouldBeAbleToLeaveRoomForCream()
        {
            JurrasicJava java = new JurrasicJava();
            java.LeaveRoomForCream();
            Assert.True(java.RoomForCream);
        }

        ///The JurassicJava should have correct default ingredients set
        [Fact]
        public void ShouldHaveCorrectDefaultIngredients()
        {
            JurrasicJava java = new JurrasicJava();
            Assert.Contains<string>("Water", java.Ingredients);
            Assert.Contains<string>("Coffee", java.Ingredients);
            Assert.Equal<int>(2, java.Ingredients.Count);
        }
    }
}
