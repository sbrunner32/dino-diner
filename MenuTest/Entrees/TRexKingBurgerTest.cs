using System.Collections.Generic;
using Xunit;
using DinoDiner.Menu.Entrees;

namespace MenuTest.Entrees
{
    public class TRexKingBurgerUnitTest
    {
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            TRexKingBurger trex = new TRexKingBurger();
            Assert.Equal(8.45, trex.Price, 2);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            TRexKingBurger trex = new TRexKingBurger();
            Assert.Equal<uint>(728, trex.Calories);
        }

        [Fact]
        public void ShouldListDefaultIngredients()
        {
            TRexKingBurger trex = new TRexKingBurger();
            List<string> ingredients = trex.Ingredients;
            Assert.Contains<string>("Whole Wheat Bun", ingredients);
            // Should be three patties
            int count = 0;
            foreach(string ingredient in ingredients)
            {
                if (ingredient.Equals("Steakburger Pattie")) count++;
            }
            Assert.Equal<int>(3, count);
            Assert.Contains<string>("Lettuce", ingredients);
            Assert.Contains<string>("Tomato", ingredients);
            Assert.Contains<string>("Onion", ingredients);
            Assert.Contains<string>("Pickle", ingredients);
            Assert.Contains<string>("Ketchup", ingredients);
            Assert.Contains<string>("Mustard", ingredients);
            Assert.Contains<string>("Mayo", ingredients);
            Assert.Equal<int>(11, ingredients.Count);
        }

        [Fact]
        public void HoldBunShouldRemoveBun()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldBun();
            Assert.DoesNotContain<string>("Whole Wheat Bun", trex.Ingredients);
        }

        [Fact]
        public void HoldLettuceShouldRemoveLettuce()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldLettuce();
            Assert.DoesNotContain<string>("Lettuce", trex.Ingredients);
        }

        [Fact]
        public void HoldTomatoShouldRemoveTomato()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldTomato();
            Assert.DoesNotContain<string>("Tomato", trex.Ingredients);
        }

        [Fact]
        public void HoldOnionShouldRemoveOnion()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldOnion();
            Assert.DoesNotContain<string>("Onion", trex.Ingredients);
        }

        [Fact]
        public void HoldPickleShouldRemovePickle()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldPickle();
            Assert.DoesNotContain<string>("Pickle", trex.Ingredients);
        }

        [Fact]
        public void HoldKetchupShouldRemoveKetchup()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldKetchup();
            Assert.DoesNotContain<string>("Ketchup", trex.Ingredients);
        }

        [Fact]
        public void HoldMustardShouldRemoveMustard()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldMustard();
            Assert.DoesNotContain<string>("Mustard", trex.Ingredients);
        }

        [Fact]
        public void HoldMayoShouldRemoveMayo()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldMayo();
            Assert.DoesNotContain<string>("Mayo", trex.Ingredients);
        }

        [Fact]
        public void ShouldHaveCorrectToString()
        {
            TRexKingBurger tb = new TRexKingBurger();
            Assert.Equal("T-Rex King Burger", tb.ToString());
        }


        [Fact]
        public void ShouldHaveCorrectDescription()
        {
            TRexKingBurger tb = new TRexKingBurger();
            Assert.Equal("T-Rex King Burger", tb.Description);
        }

        [Fact]
        public void HoldBunShouldNotifyOfSpeicalPropertyChange()
        {
            TRexKingBurger tb = new TRexKingBurger();
            Assert.PropertyChanged(tb, "Special", () =>
            {
                tb.HoldBun();
            });
        }

        [Fact]
        public void HoldLettuceShouldNotifyOfSpeicalPropertyChange()
        {
            TRexKingBurger tb = new TRexKingBurger();
            Assert.PropertyChanged(tb, "Special", () =>
            {
                tb.HoldLettuce();
            });
        }


        [Fact]
        public void HoldTomatoShouldNotifyOfSpeicalPropertyChange()
        {
            TRexKingBurger tb = new TRexKingBurger();
            Assert.PropertyChanged(tb, "Special", () =>
            {
                tb.HoldTomato();
            });
        }

        [Fact]
        public void HoldOnionShouldNotifyOfSpeicalPropertyChange()
        {
            TRexKingBurger tb = new TRexKingBurger();
            Assert.PropertyChanged(tb, "Special", () =>
            {
                tb.HoldOnion();
            });
        }

        [Fact]
        public void HoldPickleShouldNotifyOfSpeicalPropertyChange()
        {
            TRexKingBurger tb = new TRexKingBurger();
            Assert.PropertyChanged(tb, "Special", () =>
            {
                tb.HoldPickle();
            });
        }

        [Fact]
        public void HoldKetchupShouldNotifyOfSpeicalPropertyChange()
        {
            TRexKingBurger tb = new TRexKingBurger();
            Assert.PropertyChanged(tb, "Special", () =>
            {
                tb.HoldKetchup();
            });
        }

        [Fact]
        public void HoldMustardShouldNotifyOfSpeicalPropertyChange()
        {
            TRexKingBurger tb = new TRexKingBurger();
            Assert.PropertyChanged(tb, "Special", () =>
            {
                tb.HoldMustard();
            });
        }

        [Fact]
        public void HoldMayoShouldNotifyOfSpeicalPropertyChange()
        {
            TRexKingBurger tb = new TRexKingBurger();
            Assert.PropertyChanged(tb, "Special", () =>
            {
                tb.HoldMayo();
            });
        }

        [Fact]
        public void SpecialShouldHoldBun()
        {
            TRexKingBurger tb = new TRexKingBurger();
            tb.HoldBun();
            Assert.Collection<string>(tb.Special,
                item =>
                {
                    Assert.Equal("Hold Bun", item);
                }
            );
        }

        [Fact]
        public void SpecialShouldHoldLettuce()
        {
            TRexKingBurger tb = new TRexKingBurger();
            tb.HoldLettuce();
            Assert.Collection<string>(tb.Special,
                item =>
                {
                    Assert.Equal("Hold Lettuce", item);
                }
            );
        }

        [Fact]
        public void SpecialShouldHoldTomato()
        {
            TRexKingBurger tb = new TRexKingBurger();
            tb.HoldTomato();
            Assert.Collection<string>(tb.Special,
                item =>
                {
                    Assert.Equal("Hold Tomato", item);
                }
            );
        }

        [Fact]
        public void SpecialShouldHoldOnion()
        {
            TRexKingBurger tb = new TRexKingBurger();
            tb.HoldOnion();
            Assert.Collection<string>(tb.Special,
                item =>
                {
                    Assert.Equal("Hold Onion", item);
                }
            );
        }

        [Fact]
        public void SpecialShouldHoldPickle()
        {
            TRexKingBurger tb = new TRexKingBurger();
            tb.HoldPickle();
            Assert.Collection<string>(tb.Special,
                item =>
                {
                    Assert.Equal("Hold Pickle", item);
                }
            );
        }

        [Fact]
        public void SpecialShouldHoldKetchup()
        {
            TRexKingBurger tb = new TRexKingBurger();
            tb.HoldKetchup();
            Assert.Collection<string>(tb.Special,
                item =>
                {
                    Assert.Equal("Hold Ketchup", item);
                }
            );
        }

        [Fact]
        public void SpecialShouldHoldMustard()
        {
            TRexKingBurger tb = new TRexKingBurger();
            tb.HoldMustard();
            Assert.Collection<string>(tb.Special,
                item =>
                {
                    Assert.Equal("Hold Mustard", item);
                }
            );
        }

        [Fact]
        public void SpecialShouldHoldMayo()
        {
            TRexKingBurger tb = new TRexKingBurger();
            tb.HoldMayo();
            Assert.Collection<string>(tb.Special,
                item =>
                {
                    Assert.Equal("Hold Mayo", item);
                }
            );
        }

        [Fact]
        public void SpecialShouldHoldBunAndLettuce()
        {
            TRexKingBurger tb = new TRexKingBurger();
            tb.HoldBun();
            tb.HoldLettuce();
            Assert.Collection<string>(tb.Special,
                item =>
                {
                    Assert.Equal("Hold Bun", item);
                },
                item =>
                {
                    Assert.Equal("Hold Lettuce", item);
                }
            );
        }


        [Fact]
        public void SpecialShouldHoldTomatoAndOnion()
        {
            TRexKingBurger tb = new TRexKingBurger();
            tb.HoldTomato();
            tb.HoldOnion();
            Assert.Collection<string>(tb.Special,
                item =>
                {
                    Assert.Equal("Hold Tomato", item);
                },
                item =>
                {
                    Assert.Equal("Hold Onion", item);
                }
            );
        }

        [Fact]
        public void SpecialShouldHoldPickleAndKetchup()
        {
            TRexKingBurger tb = new TRexKingBurger();
            tb.HoldPickle();
            tb.HoldKetchup();
            Assert.Collection<string>(tb.Special,
                item =>
                {
                    Assert.Equal("Hold Pickle", item);
                },
                item =>
                {
                    Assert.Equal("Hold Ketchup", item);
                }
            );
        }

        [Fact]
        public void SpecialShouldHoldMustardAndMayo()
        {
            TRexKingBurger tb = new TRexKingBurger();
            tb.HoldMustard();
            tb.HoldMayo();
            Assert.Collection<string>(tb.Special,
                item =>
                {
                    Assert.Equal("Hold Mustard", item);
                },
                item =>
                {
                    Assert.Equal("Hold Mayo", item);
                }
            );
        }


        [Fact]
        public void SpecialShouldHoldBunLettuceAndTomato()
        {
            TRexKingBurger tb = new TRexKingBurger();
            tb.HoldBun();
            tb.HoldLettuce();
            tb.HoldTomato();
            Assert.Collection<string>(tb.Special,
                item =>
                {
                    Assert.Equal("Hold Bun", item);
                },
                item =>
                {
                    Assert.Equal("Hold Lettuce", item);
                },
                item =>
                {
                    Assert.Equal("Hold Tomato", item);
                }
            );
        }

        [Fact]
        public void SpecialShouldHoldOnionPickleAndKetchup()
        {
            TRexKingBurger tb = new TRexKingBurger();
            tb.HoldOnion();
            tb.HoldPickle();
            tb.HoldKetchup();
            Assert.Collection<string>(tb.Special,
                item =>
                {
                    Assert.Equal("Hold Onion", item);
                },
                item =>
                {
                    Assert.Equal("Hold Pickle", item);
                },
                item =>
                {
                    Assert.Equal("Hold Ketchup", item);
                }
            );
        }

        [Fact]
        public void SpecialShouldHoldBunMustardAndMayo()
        {
            TRexKingBurger tb = new TRexKingBurger();
            tb.HoldBun();
            tb.HoldMustard();
            tb.HoldMayo();
            Assert.Collection<string>(tb.Special,
                item =>
                {
                    Assert.Equal("Hold Bun", item);
                },
                item =>
                {
                    Assert.Equal("Hold Mustard", item);
                },
                item =>
                {
                    Assert.Equal("Hold Mayo", item);
                }
            );
        }


        [Fact]
        public void SpecialShouldHoldBunTomatoAndPickle()
        {
            TRexKingBurger tb = new TRexKingBurger();
            tb.HoldBun();
            tb.HoldTomato();
            tb.HoldPickle();
            Assert.Collection<string>(tb.Special,
                item =>
                {
                    Assert.Equal("Hold Bun", item);
                },
                item =>
                {
                    Assert.Equal("Hold Tomato", item);
                },
                item =>
                {
                    Assert.Equal("Hold Pickle", item);
                }
            );
        }

        [Fact]
        public void SpecialShouldHoldBunLettuceTomatoAndOnion()
        {
            TRexKingBurger tb = new TRexKingBurger();
            tb.HoldBun();
            tb.HoldLettuce();
            tb.HoldTomato();
            tb.HoldOnion();
            Assert.Collection<string>(tb.Special,
                item =>
                {
                    Assert.Equal("Hold Bun", item);
                },
                item =>
                {
                    Assert.Equal("Hold Lettuce", item);
                },
                item =>
                {
                    Assert.Equal("Hold Tomato", item);
                },
                item =>
                {
                    Assert.Equal("Hold Onion", item);
                }
            );
        }

        [Fact]
        public void SpecialShouldHoldPickleKetchupMustardAndMayo()
        {
            TRexKingBurger tb = new TRexKingBurger();
            tb.HoldPickle();
            tb.HoldKetchup();
            tb.HoldMustard();
            tb.HoldMayo();
            Assert.Collection<string>(tb.Special,
                item =>
                {
                    Assert.Equal("Hold Pickle", item);
                },
                item =>
                {
                    Assert.Equal("Hold Ketchup", item);
                },
                item =>
                {
                    Assert.Equal("Hold Mustard", item);
                },
                item =>
                {
                    Assert.Equal("Hold Mayo", item);
                }
            );
        }


        [Fact]
        public void SpecialShouldHoldBunTomatoPickleAndMustard()
        {
            TRexKingBurger tb = new TRexKingBurger();
            tb.HoldBun();            
            tb.HoldTomato();
            tb.HoldPickle();
            tb.HoldMustard();
            Assert.Collection<string>(tb.Special,
                item =>
                {
                    Assert.Equal("Hold Bun", item);
                },
                item =>
                {
                    Assert.Equal("Hold Tomato", item);
                },
                item =>
                {
                    Assert.Equal("Hold Pickle", item);
                },
                item =>
                {
                    Assert.Equal("Hold Mustard", item);
                }
            );
        }


        [Fact]
        public void SpecialShouldHoldLettuceOnionKetchupAndMayo()
        {
            TRexKingBurger tb = new TRexKingBurger();            
            tb.HoldLettuce();
            tb.HoldOnion();
            tb.HoldKetchup();
            tb.HoldMayo();
            Assert.Collection<string>(tb.Special,
                item =>
                {
                    Assert.Equal("Hold Lettuce", item);
                },
                item =>
                {
                    Assert.Equal("Hold Onion", item);
                },
                item =>
                {
                    Assert.Equal("Hold Ketchup", item);
                },
                item =>
                {
                    Assert.Equal("Hold Mayo", item);
                }
            );
        }

        [Fact]
        public void SpecialShouldHoldBunLettuceTomatoOnionAndPickle()
        {
            TRexKingBurger tb = new TRexKingBurger();
            tb.HoldBun();
            tb.HoldLettuce();
            tb.HoldTomato();
            tb.HoldOnion();
            tb.HoldPickle();
            Assert.Collection<string>(tb.Special,
                item =>
                {
                    Assert.Equal("Hold Bun", item);
                },
                item =>
                {
                    Assert.Equal("Hold Lettuce", item);
                },
                item =>
                {
                    Assert.Equal("Hold Tomato", item);
                },
                item =>
                {
                    Assert.Equal("Hold Onion", item);
                },
                item =>
                {
                    Assert.Equal("Hold Pickle", item);
                }
            );
        }

        [Fact]
        public void SpecialShouldHoldOnionPickleKetchupMustardAndMayo()
        {
            TRexKingBurger tb = new TRexKingBurger();
            tb.HoldOnion();
            tb.HoldPickle();
            tb.HoldKetchup();
            tb.HoldMustard();
            tb.HoldMayo();
            Assert.Collection<string>(tb.Special,                
                item =>
                {
                    Assert.Equal("Hold Onion", item);
                },
                item =>
                {
                    Assert.Equal("Hold Pickle", item);
                },
                item =>
                {
                    Assert.Equal("Hold Ketchup", item);
                },
                item =>
                {
                    Assert.Equal("Hold Mustard", item);
                },
                item =>
                {
                    Assert.Equal("Hold Mayo", item);
                }
            );
        }

        [Fact]
        public void SpecialShouldHoldBunTomatoPickleMustardAndMayo()
        {
            TRexKingBurger tb = new TRexKingBurger();
            tb.HoldBun();
            tb.HoldTomato();
            tb.HoldPickle();
            tb.HoldMustard();
            tb.HoldMayo();
            Assert.Collection<string>(tb.Special,
                item =>
                {
                    Assert.Equal("Hold Bun", item);
                },
                item =>
                {
                    Assert.Equal("Hold Tomato", item);
                },
                item =>
                {
                    Assert.Equal("Hold Pickle", item);
                },
                item =>
                {
                    Assert.Equal("Hold Mustard", item);
                },
                item =>
                {
                    Assert.Equal("Hold Mayo", item);
                }
            );
        }

        [Fact]
        public void SpecialShouldHoldBunLettuceTomatoOnionPickleAndKetchup()
        {
            TRexKingBurger tb = new TRexKingBurger();
            tb.HoldBun();
            tb.HoldLettuce();
            tb.HoldTomato();
            tb.HoldOnion();
            tb.HoldPickle();
            tb.HoldKetchup();
            Assert.Collection<string>(tb.Special,
                item =>
                {
                    Assert.Equal("Hold Bun", item);
                },
                item =>
                {
                    Assert.Equal("Hold Lettuce", item);
                },
                item =>
                {
                    Assert.Equal("Hold Tomato", item);
                },
                item =>
                {
                    Assert.Equal("Hold Onion", item);
                },
                item =>
                {
                    Assert.Equal("Hold Pickle", item);
                },
                item =>
                {
                    Assert.Equal("Hold Ketchup", item);
                }
            );
        }

        [Fact]
        public void SpecialShouldHoldTomatoOnionPickleKetchupMustardAndMayo()
        {
            TRexKingBurger tb = new TRexKingBurger();  
            tb.HoldTomato();
            tb.HoldOnion();
            tb.HoldPickle();
            tb.HoldKetchup();
            tb.HoldMustard();
            tb.HoldMayo();
            Assert.Collection<string>(tb.Special,                
                item =>
                {
                    Assert.Equal("Hold Tomato", item);
                },
                item =>
                {
                    Assert.Equal("Hold Onion", item);
                },
                item =>
                {
                    Assert.Equal("Hold Pickle", item);
                },
                item =>
                {
                    Assert.Equal("Hold Ketchup", item);
                },
                item =>
                {
                    Assert.Equal("Hold Mustard", item);
                },
                item =>
                {
                    Assert.Equal("Hold Mayo", item);
                }
            );
        }
        [Fact]
        public void SpecialShouldHoldBunLettuceTomatoOnionPickleKetchupAndMustard()
        {
            TRexKingBurger tb = new TRexKingBurger();
            tb.HoldBun();
            tb.HoldLettuce();
            tb.HoldTomato();
            tb.HoldOnion();
            tb.HoldPickle();
            tb.HoldKetchup();
            tb.HoldMustard();
            Assert.Collection<string>(tb.Special,
                item =>
                {
                    Assert.Equal("Hold Bun", item);
                },
                item =>
                {
                    Assert.Equal("Hold Lettuce", item);
                },
                item =>
                {
                    Assert.Equal("Hold Tomato", item);
                },
                item =>
                {
                    Assert.Equal("Hold Onion", item);
                },
                item =>
                {
                    Assert.Equal("Hold Pickle", item);
                },
                item =>
                {
                    Assert.Equal("Hold Ketchup", item);
                },
                item =>
                {
                    Assert.Equal("Hold Mustard", item);
                }
            );
        }

        [Fact]
        public void SpecialShouldHoldLettuceTomatoOnionPickleKetchupMustardAndMayo()
        {
            TRexKingBurger tb = new TRexKingBurger();
            tb.HoldLettuce();
            tb.HoldTomato();
            tb.HoldOnion();
            tb.HoldPickle();
            tb.HoldKetchup();
            tb.HoldMustard();
            tb.HoldMayo();
            Assert.Collection<string>(tb.Special,              
                item =>
                {
                    Assert.Equal("Hold Lettuce", item);
                },
                item =>
                {
                    Assert.Equal("Hold Tomato", item);
                },
                item =>
                {
                    Assert.Equal("Hold Onion", item);
                },
                item =>
                {
                    Assert.Equal("Hold Pickle", item);
                },
                item =>
                {
                    Assert.Equal("Hold Ketchup", item);
                },
                item =>
                {
                    Assert.Equal("Hold Mustard", item);
                },
                item =>
                {
                    Assert.Equal("Hold Mayo", item);
                }
            );
        }


        [Fact]
        public void SpecialShouldHoldEverything()
        {
            TRexKingBurger tb = new TRexKingBurger();
            tb.HoldBun();
            tb.HoldLettuce();
            tb.HoldTomato();
            tb.HoldOnion();
            tb.HoldPickle();
            tb.HoldKetchup();
            tb.HoldMustard();
            tb.HoldMayo();
            Assert.Collection<string>(tb.Special,
                item =>
                {
                    Assert.Equal("Hold Bun", item);
                },
                item =>
                {
                    Assert.Equal("Hold Lettuce", item);
                },
                item =>
                {
                    Assert.Equal("Hold Tomato", item);
                },
                item =>
                {
                    Assert.Equal("Hold Onion", item);
                },
                item =>
                {
                    Assert.Equal("Hold Pickle", item);
                },
                item =>
                {
                    Assert.Equal("Hold Ketchup", item);
                },
                item =>
                {
                    Assert.Equal("Hold Mustard", item);
                },
                item =>
                {
                    Assert.Equal("Hold Mayo", item);
                }
            );
        }

        [Fact]
        public void ShouldHaveEmptySpecialListByDefualt()
        {
            TRexKingBurger tb = new TRexKingBurger();
            Assert.Empty(tb.Special);
        }



    }

}
