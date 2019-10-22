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
            JurassicJava java = new JurassicJava();
            Assert.Equal<double>(0.59, java.Price);
        }

        /// The default Ice value should be False.    
        [Fact]
        public void ShouldHaveDefaultIce()
        {
            JurassicJava java = new JurassicJava();
            Assert.False(java.Ice);
        }

        /// The default Size should be small
        [Fact]
        public void ShouldHaveCorrectDefaultSize()
        {
            JurassicJava java = new JurassicJava();
            Assert.Equal<Size>(Size.Small, java.Size);
        }

        ///The default calories should be 2
        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            JurassicJava java = new JurassicJava();
            Assert.Equal<uint>(2, java.Calories);
        }

        ///The correct default RoomForCream value is set to false
        [Fact]
        public void ShouldHaveCorrectDefaultRoomForCream()
        {
            JurassicJava java = new JurassicJava();
            Assert.False(java.RoomForCream);
        }

        ///The price should change accordingly when the size changes to small
        [Fact]
        public void ShouldHaveCorrectSmallPrice()
        {
            JurassicJava java = new JurassicJava();
            java.Size = Size.Medium;
            java.Size = Size.Small;
            Assert.Equal<double>(0.59, java.Price);
        }

        ///The price should change accordingly when the size changes to medium
        [Fact]
        public void ShouldHaveCorrectMediumPrice()
        {
            JurassicJava java = new JurassicJava();
            java.Size = Size.Medium;   
            Assert.Equal<double>(0.99, java.Price);
        }

        ///The price should change accordingly when the size changes to Large
        [Fact]
        public void ShouldHaveCorrectLargePrice()
        {
            JurassicJava java = new JurassicJava();
            java.Size = Size.Large;
            Assert.Equal<double>(1.49, java.Price);
        }

        ///The calories should adjust accordingly when the size changes to small
        [Fact]
        public void ShouldHaveCorrectSmallCalories()
        {
            JurassicJava java = new JurassicJava();
            java.Size = Size.Medium;
            java.Size = Size.Small;
            Assert.Equal<uint>(2, java.Calories);
        }

        ///The calories should adjust accordingly when the size changes to medium
        [Fact]
        public void ShouldHaveCorrectMediumCalories()
        {
            JurassicJava java = new JurassicJava();
            java.Size = Size.Medium;     
            Assert.Equal<uint>(4, java.Calories);
        }

        ///The calories should adjust accordingly when the size changes to large
        [Fact]
        public void ShouldHaveCorrectLargeCalories()
        {
            JurassicJava java = new JurassicJava();
            java.Size = Size.Large;
            Assert.Equal<uint>(8, java.Calories);
        }

        ///That invoking AddIce() results in the Ice property being true.
        [Fact]
        public void ShouldBeAbleToHoldIce()
        {
            JurassicJava java = new JurassicJava();
            java.AddIce();
            Assert.True(java.Ice);
        }


        ///That invoking LeaveRoomForCream() results in the RoomForCream property being true.
        [Fact]
        public void ShouldBeAbleToLeaveRoomForCream()
        {
            JurassicJava java = new JurassicJava();
            java.LeaveRoomForCream();
            Assert.True(java.RoomForCream);
        }

        ///The JurassicJava should have correct default ingredients set
        [Fact]
        public void ShouldHaveCorrectDefaultIngredients()
        {
            JurassicJava java = new JurassicJava();
            Assert.Contains<string>("Water", java.Ingredients);
            Assert.Contains<string>("Coffee", java.Ingredients);
            Assert.Equal<int>(2, java.Ingredients.Count);
        }

        [Fact]
        public void ShouldHaveEmptySpecialListByDefualt()
        {
            JurassicJava jj = new JurassicJava();
            Assert.Empty(jj.Special);
        }

        [Fact]
        public void LeaveRoomForCreamShouldNotifyOfSpecialPropertyChange()
        {
            JurassicJava jj = new JurassicJava();
            Assert.PropertyChanged(jj, "Special", () =>
            {
                jj.LeaveRoomForCream();
            });
        }

        [Fact]
        public void AddIceShouldNotifyOfSpecialPropertyChange()
        {
            JurassicJava jj = new JurassicJava();
            Assert.PropertyChanged(jj, "Special", () =>
            {
                jj.AddIce();
            });
        }

        [Fact]
        public void ResizingShouldNotifyOfPricePropertyChange()
        {
            JurassicJava jj = new JurassicJava();
            Assert.PropertyChanged(jj, "Price", () =>
            {
                jj.Size=Size.Large;
            });
        }

        [Fact]
        public void ResizingShouldNotifyOfDescriptionPropertyChange()
        {
            JurassicJava jj = new JurassicJava();
            Assert.PropertyChanged(jj, "Description", () =>
            {
                jj.Size = Size.Large;
            });
        }

        [Fact]
        public void ShouldHaveCorrectToString()
        {
            JurassicJava jj = new JurassicJava();
            Assert.Equal(($"{jj.Size} Jurassic Java"), jj.ToString());
        }

        [Fact]
        public void ShouldHaveCorrectDescription()
        {
            JurassicJava jj = new JurassicJava();
            Assert.Equal(($"{jj.Size} Jurassic Java"), jj.Description);
        }

        [Fact]
        public void SpecialShouldAddIce()
        {
            JurassicJava jj = new JurassicJava();
            jj.AddIce();
            Assert.Collection<string>(jj.Special,
                item =>
                {
                    Assert.Equal("Add Ice", item);
                }
            );
        }


        [Fact]
        public void SpecialShouldLeaveRoomForCream()
        {
            JurassicJava jj = new JurassicJava();
            jj.LeaveRoomForCream();
            Assert.Collection<string>(jj.Special,
                item =>
                {
                    Assert.Equal("Room For Cream", item);
                }
            );
        }


        [Fact]
        public void SpecialShouldAddIceAndLeaveRoomForCream()
        {
            JurassicJava jj = new JurassicJava();
            jj.AddIce();
            jj.LeaveRoomForCream();
            Assert.Collection<string>(jj.Special,
                item =>
                {
                    Assert.Equal("Add Ice", item);
                },
                item =>
                {
                    Assert.Equal("Room For Cream", item);
                }
            );
        }

        

    }
}
