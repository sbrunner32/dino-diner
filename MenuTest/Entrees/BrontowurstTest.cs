using System.Collections.Generic;
using Xunit;
using DinoDiner.Menu.Entrees;

namespace MenuTest.Entrees
{
    public class BrontowurstUnitTest
    {
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            Brontowurst bw = new Brontowurst();
            Assert.Equal(5.36, bw.Price, 2);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            Brontowurst bw = new Brontowurst();
            Assert.Equal<uint>(498, bw.Calories);
        }

        [Fact]
        public void ShouldListDefaultIngredients()
        {
            Brontowurst bw = new Brontowurst();
            List<string> ingredients = bw.Ingredients;
            Assert.Contains<string>("Whole Wheat Bun", ingredients);
            Assert.Contains<string>("Brautwurst", ingredients);
            Assert.Contains<string>("Peppers", ingredients);
            Assert.Contains<string>("Onion", ingredients);
            Assert.Equal<int>(4, ingredients.Count);
        }

        [Fact]
        public void HoldBunShouldRemoveBun()
        {
            Brontowurst bw = new Brontowurst();
            bw.HoldBun();
            Assert.DoesNotContain<string>("Whole Wheat Bun", bw.Ingredients);
        }

        [Fact]
        public void HoldPeppersShouldRemovePeppers()
        {
            Brontowurst bw = new Brontowurst();
            bw.HoldPeppers();
            Assert.DoesNotContain<string>("Peppers", bw.Ingredients);
        }

        [Fact]
        public void HoldOnionShouldRemoveOnion()
        {
            Brontowurst bw = new Brontowurst();
            bw.HoldOnion();
            Assert.DoesNotContain<string>("Onion", bw.Ingredients);
        }

        [Fact]
        public void HoldBunShouldNotifyOfSpeicalPropertyChange()
        {
            Brontowurst b = new Brontowurst();
            Assert.PropertyChanged(b, "Special", () =>
            {
                b.HoldBun();
            });
        }

        [Fact]
        public void HoldPeppersShouldNotifyOfSpeicalPropertyChange()
        {
            Brontowurst b = new Brontowurst();
            Assert.PropertyChanged(b, "Special", () =>
            {
                b.HoldPeppers();
            });
        }

        [Fact]
        public void HoldOnionShouldNotifyOfSpeicalPropertyChange()
        {
            Brontowurst b = new Brontowurst();
            Assert.PropertyChanged(b, "Special", () =>
            {
                b.HoldOnion();
            });
        }

        [Fact]
        public void SpecialShouldHoldBun()
        {
            Brontowurst b = new Brontowurst();
            b.HoldBun();
            Assert.Collection<string>(b.Special,
                item =>
                {
                    Assert.Equal("Hold Bun", item);
                }
            );
        }

        [Fact]
        public void SpecialShouldHoldPeppers()
        {
            Brontowurst b = new Brontowurst();
            b.HoldPeppers();
            Assert.Collection<string>(b.Special,
                item =>
                {
                    Assert.Equal("Hold Peppers", item);
                }
            );
        }

        [Fact]
        public void SpecialShouldHoldOnion()
        {
            Brontowurst b = new Brontowurst();
            b.HoldOnion();
            Assert.Collection<string>(b.Special,
                item =>
                {
                    Assert.Equal("Hold Onion", item);
                }
            );
        }

        [Fact]
        public void SpecialShouldHoldBunAndOnion()
        {
            Brontowurst b = new Brontowurst();
            b.HoldBun();
            b.HoldOnion();
            Assert.Collection<string>(b.Special,
                item =>
                {
                    Assert.Equal("Hold Bun", item);
                },
                item =>
                {
                    Assert.Equal("Hold Onion", item);
                }
            );
        }

        [Fact]
        public void SpecialShouldHoldPeppersAndOnions()
        {
            Brontowurst b = new Brontowurst();
            b.HoldPeppers();
            b.HoldOnion();
            Assert.Collection<string>(b.Special,
                item =>
                {
                    Assert.Equal("Hold Peppers", item);
                },
                item =>
                {
                    Assert.Equal("Hold Onion", item);
                }
            );
        }

        [Fact]
        public void SpecialShouldHoldEverything()
        {
            Brontowurst b = new Brontowurst();
            b.HoldBun();
            b.HoldPeppers();
            b.HoldOnion();
            Assert.Collection<string>(b.Special,
                item =>
                {
                    Assert.Equal("Hold Bun", item);
                },
                 item =>
                 {
                     Assert.Equal("Hold Peppers", item);
                 },
                item =>
                {
                    Assert.Equal("Hold Onion", item);
                }
            );
        }

        [Fact]
        public void ShouldHaveCorrectToString()
        {
            Brontowurst b = new Brontowurst();
            Assert.Equal("Brontowurst", b.ToString());
        }

        [Fact]
        public void ShouldHaveCorrectDescription()
        {
            Brontowurst b = new Brontowurst();
            Assert.Equal("Brontowurst", b.Description);
        }

        [Fact]
        public void ShouldHaveEmptySpecialListByDefualt()
        {
            Brontowurst b = new Brontowurst();
            Assert.Empty(b.Special);
        }
    }

}
