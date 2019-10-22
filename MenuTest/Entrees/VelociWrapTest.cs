﻿using System.Collections.Generic;
using Xunit;
using DinoDiner.Menu.Entrees;

namespace MenuTest.Entrees
{
    public class VelociWrapUnitTest
    {
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            VelociWrap vw = new VelociWrap();
            Assert.Equal(6.86, vw.Price, 2);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            VelociWrap vw = new VelociWrap();
            Assert.Equal<uint>(356, vw.Calories);
        }

        [Fact]
        public void ShouldListDefaultIngredients()
        {
            VelociWrap vw = new VelociWrap();
            List<string> ingredients = vw.Ingredients;
            Assert.Contains<string>("Flour Tortilla", ingredients);
            Assert.Contains<string>("Chicken Breast", ingredients);
            Assert.Contains<string>("Romaine Lettuce", ingredients);
            Assert.Contains<string>("Ceasar Dressing", ingredients);
            Assert.Contains<string>("Parmesan Cheese", ingredients);
            Assert.Equal<int>(5, ingredients.Count);
        }

        [Fact]
        public void HoldDressingShouldRemoveDressing()
        {
            VelociWrap vw = new VelociWrap();
            vw.HoldDressing();
            Assert.DoesNotContain<string>("Dressing", vw.Ingredients);
        }

        [Fact]
        public void HoldLettuceShouldRemoveLettuce()
        {
            VelociWrap vw = new VelociWrap();
            vw.HoldLettuce();
            Assert.DoesNotContain<string>("Lettuce", vw.Ingredients);
        }

        [Fact]
        public void HoldCheeseShouldRemoveCheese()
        {
            VelociWrap vw = new VelociWrap();
            vw.HoldCheese();
            Assert.DoesNotContain<string>("Parmesan Cheese", vw.Ingredients);
        }

        [Fact]
        public void ShouldHaveCorrectToString()
        {
            VelociWrap vw = new VelociWrap();
            Assert.Equal("Veloci-Wrap", vw.ToString());
        }

        [Fact]
        public void ShouldHaveCorrectDescription()
        {
            VelociWrap vw = new VelociWrap();
            Assert.Equal("Veloci-Wrap", vw.Description);
        }

        [Fact]
        public void HoldDressingShouldNotifyOfSpeicalPropertyChange()
        {
            VelociWrap vw = new VelociWrap();
            Assert.PropertyChanged(vw, "Special", () =>
            {
                vw.HoldDressing();
            });
        }

        [Fact]
        public void HoldLettuceShouldNotifyOfSpeicalPropertyChange()
        {
            VelociWrap vw = new VelociWrap();
            Assert.PropertyChanged(vw, "Special", () =>
            {
                vw.HoldLettuce();
            });
        }

        [Fact]
        public void HoldCheeseShouldNotifyOfSpeicalPropertyChange()
        {
            VelociWrap vw = new VelociWrap();
            Assert.PropertyChanged(vw, "Special", () =>
            {
                vw.HoldCheese();
            });
        }

        [Fact]
        public void ShouldHaveEmptySpecialListByDefualt()
        {
            VelociWrap vw = new VelociWrap();
            Assert.Empty(vw.Special);
        }

        [Fact]
        public void SpecialShouldHoldDressing()
        {
            VelociWrap vw = new VelociWrap();
            vw.HoldDressing();
            Assert.Collection<string>(vw.Special,
                item =>
                {
                    Assert.Equal("Hold Dressing", item);
                }
            );
        }

        [Fact]
        public void SpecialShouldHoldLettuce()
        {
            VelociWrap vw = new VelociWrap();
            vw.HoldLettuce();
            Assert.Collection<string>(vw.Special,
                item =>
                {
                    Assert.Equal("Hold Lettuce", item);
                }
            );
        }

        [Fact]
        public void SpecialShouldHoldCheese()
        {
            VelociWrap vw = new VelociWrap();
            vw.HoldCheese();
            Assert.Collection<string>(vw.Special,
                item =>
                {
                    Assert.Equal("Hold Cheese", item);
                }
            );
        }

        [Fact]
        public void SpecialShouldHoldDressingAndLettuce()
        {
            VelociWrap vw = new VelociWrap();
            vw.HoldDressing();
            vw.HoldLettuce();
            Assert.Collection<string>(vw.Special,
                item =>
                {
                    Assert.Equal("Hold Dressing", item);
                },
                item =>
                {
                    Assert.Equal("Hold Lettuce", item);
                }
            );
        }

        [Fact]
        public void SpecialShouldHoldDressingAndCheese()
        {
            VelociWrap vw = new VelociWrap();
            vw.HoldDressing();
            vw.HoldCheese();
            Assert.Collection<string>(vw.Special,
                item =>
                {
                    Assert.Equal("Hold Dressing", item);
                },
                item =>
                {
                    Assert.Equal("Hold Cheese", item);
                }
            );
        }

        [Fact]
        public void SpecialShouldHoldLettuceAndCheese()
        {
            VelociWrap vw = new VelociWrap();
            vw.HoldLettuce();
            vw.HoldCheese();
            Assert.Collection<string>(vw.Special,
                item =>
                {
                    Assert.Equal("Hold Lettuce", item);
                },
                item =>
                {
                    Assert.Equal("Hold Cheese", item);
                }
            );
        }

        [Fact]
        public void SpecialShouldHoldEverything()
        {
            VelociWrap vw = new VelociWrap();
            vw.HoldDressing();
            vw.HoldLettuce();
            vw.HoldCheese();
            Assert.Collection<string>(vw.Special,
                item =>
                {
                    Assert.Equal("Hold Dressing", item);
                },
                item =>
                {
                    Assert.Equal("Hold Lettuce", item);
                },
                item =>
                {
                    Assert.Equal("Hold Cheese", item);
                }
            );
        }




    }
}
