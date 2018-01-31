using Microsoft.VisualStudio.TestTools.UnitTesting;
using MTGCards;
using System.Collections.Generic;

namespace MTGCardsTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CreateScarabGod()
        {
            var result = new Card();
            result.Legality = new CardLegality()
            {
                Commander = true,
                Modern = true,
                Standard = true,
                Vintage = true
            };

            result.Name = "The Scarab God";
            result.Description = @"At the beginning of your upkeep, each opponent loses X life and you scry X, where X is the number of Zombies you control. 
                            2UB: Exile target creature card from a graveyard.Create a token that's a copy of it, except it's a 4 / 4 black Zombie. 
                            When The Scarab God dies, return it to its owner's hand at the beginning of the next end step.";
            result.FlavorText = "";

            result.MainType = new List<CardType>() {
                new CardType(){ Name = "Legendary" },
                new CardType(){ Name = "Creature" }
            };

            result.SubType = new List<CardType>() {
                new CardType(){ Name = "God" }
            };

            result.CardSet = new CardSet()
            {
                Name = "Hour Of Devastation",
                Year = 2017,
                Block = "Amonkhet"
            };

            result.Rarity = CardRarity.Mythic;

            result.Power = 5;
            result.Toughness = 5;

            result.Manacost = new ManaCost();
            result.Manacost.ColorCost = new List<ColorCost>();
            result.Manacost.ColorCost.Add(new ColorCost() { Amount = 1, Color = Color.Black });
            result.Manacost.ColorCost.Add(new ColorCost() { Amount = 1, Color = Color.Blue });
            result.Manacost.ColorCost.Add(new ColorCost() { Amount = 3, Color = Color.NoColor });

            result.Abilities = new List<Ability>();

            result.Abilities.Add(new Ability()
            {
                Description = "At the beginning of your upkeep, each opponent loses X life and you scry X, where X is the number of Zombies you control.",
                ManaCost = null,
                X = 5,
                Effects = new List<AbilityEffect>() {
                    new AbilityEffect(){
                        EffectType = AbilityEffectType.EachOpponentLoseLife,
                        TurnStep = AbilityEffectTimeTrigger.UpkeepStart,
                        X = 5
                    },
                    new AbilityEffect(){
                        EffectType = AbilityEffectType.Scry,
                        TurnStep = AbilityEffectTimeTrigger.UpkeepStart,
                        X = 5
                    },

                }
            });

            result.Abilities.Add(new Ability()
            {
                Description = "2UB: Exile target creature card from a graveyard.Create a token that's a copy of it, except it's a 4 / 4 black Zombie.",
                ManaCost = new ManaCost()
                {
                    ColorCost = new List<ColorCost>() {
                        new ColorCost(){ Color = Color.NoColor, Amount = 2},
                        new ColorCost(){ Color = Color.Blue, Amount = 1 },
                        new ColorCost(){ Color = Color.Black, Amount = 1 }
                    }
                },
                Effects = new List<AbilityEffect>() {
                    new AbilityEffect(){
                        EffectType = AbilityEffectType.ExileCreatureCard,
                        Location = AbilityEffectLocation.AGraveyard,
                        Target = AbilityEffectTarget.Creature,
                        TurnStep = AbilityEffectTimeTrigger.Immediate
                    },
                    new AbilityEffect(){
                        EffectType = AbilityEffectType.CreateATokenCopy,
                        Target = AbilityEffectTarget.Creature,
                        Location = AbilityEffectLocation.Battlefield,
                        TurnStep = AbilityEffectTimeTrigger.Immediate,
                        CreatureToken = new AbilityCreatureToken(){
                            Power = 4,
                            Toughness = 4,
                            MainType = new List<CardType>(){
                                new CardType(){ Name = "Creature" }
                            },
                            SubType = new List<CardType>(){
                                new CardType(){ Name = "Zombie" },
                                new CardType(){ Name = "Black" }
                            }
                        }
                    }
                }
            });

            result.Abilities.Add(new Ability()
            {
                Description = "When The Scarab God dies, return it to its owner's hand at the beginning of the next end step.",
                Effects = new List<AbilityEffect>() {
                    new AbilityEffect(){
                        Event = AbilityEffectEvent.CreatureDies,
                        Target = AbilityEffectTarget.ThisCard
                    },
                    new AbilityEffect(){
                        EffectType = AbilityEffectType.ReturnToHand,
                        TurnStep = AbilityEffectTimeTrigger.End,
                        Location = AbilityEffectLocation.OwnersHand
                    }
                }
            });

        }

        [TestMethod]
        public void CreateElendaTheDuskRose() {
            var result = new Card();

            result.Legality = new CardLegality()
            {
                Commander = true,
                Modern = true,
                Standard = true,
                Vintage = true
            };

            result.Name = "Elenda, the Dusk Rose";

            result.Manacost = new ManaCost() {
                ColorCost = new List<ColorCost>() {
                    new ColorCost(){ Amount = 2, Color = Color.NoColor },
                    new ColorCost(){ Amount = 1, Color = Color.White },
                    new ColorCost(){ Amount = 1, Color = Color.Black }
                }
            };

            result.MainType = new List<CardType>() {
                new CardType() { Name = "Legendary" },
                new CardType() { Name = "Creature" }
            };

            result.SubType = new List<CardType>() {
                new CardType() { Name = "Vampire" },
                new CardType() { Name = "Knight"}
            };

            result.CardSet = new CardSet();
            result.CardSet.Name = "Rivals of Ixalan";
            result.CardSet.Year = 2018;
            result.CardSet.Block = "Ixalan";

            result.Rarity = CardRarity.Mythic;

            result.Abilities = new List<Ability>() {
                new Ability(){
                    Description = "Lifelink",
                    Effects = new List<AbilityEffect>(){
                        new AbilityEffect(){
                            EffectType = AbilityEffectType.Lifelink,
                            Target = AbilityEffectTarget.None,
                            TimeSpan = AbilityEffectTimeSpan.Forever,
                            TargetPlayer = AbilityEffectTargetPlayer.None
                        }
                    }
                },
                new Ability(){
                    Description = "Whenever another creature dies, put a +1/+1 counter on Elenda, the Dusk Rose. ",
                    Effects = new List<AbilityEffect>(){
                        new AbilityEffect(){
                            EffectType = AbilityEffectType.None,
                            Event = AbilityEffectEvent.CreatureDies,
                            Target = AbilityEffectTarget.OtherCreatures,
                            TimeSpan = AbilityEffectTimeSpan.Forever,
                            TargetPlayer = AbilityEffectTargetPlayer.None
                        },
                        new AbilityEffect(){
                            EffectType = AbilityEffectType.PutPlus11Counter,
                            Event = AbilityEffectEvent.None,
                            TimeSpan = AbilityEffectTimeSpan.Forever,
                            Target = AbilityEffectTarget.ThisCard,
                            TargetPlayer = AbilityEffectTargetPlayer.None
                        }
                    }
                },
                new Ability(){
                    Description = "When Elenda dies, create X 1/1 white Vampire creature tokens with lifelink, where X is Elenda's power.",
                    Effects = new List<AbilityEffect>(){
                        new AbilityEffect(){
                            Event = AbilityEffectEvent.CreatureDies,
                            Target = AbilityEffectTarget.ThisCard,
                            EffectType = AbilityEffectType.None,
                            TargetPlayer = AbilityEffectTargetPlayer.None,
                            TimeSpan = AbilityEffectTimeSpan.None,
                            TurnStep = AbilityEffectTimeTrigger.None
                        },
                        new AbilityEffect(){
                            Event = AbilityEffectEvent.None,
                            EffectType = AbilityEffectType.CreateAToken,
                            CreatureToken = new AbilityCreatureToken(){
                                NumOfTokensToCreate = 5,
                                Power = 1,
                                Toughness = 1,
                                MainType = new List<CardType>(){
                                    new CardType(){ Name = "Creature" }
                                },
                                SubType = new List<CardType>(){
                                    new CardType(){ Name = "Vampire" }
                                },
                                Abilities = new List<Ability>(){
                                    new Ability(){
                                        Description = "Lifelink",
                                        Effects = new List<AbilityEffect>(){
                                            new AbilityEffect(){
                                                EffectType = AbilityEffectType.Lifelink,
                                                Target = AbilityEffectTarget.None,
                                                TimeSpan = AbilityEffectTimeSpan.Forever,
                                                TargetPlayer = AbilityEffectTargetPlayer.None
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            };

        }

        [TestMethod]
        public void CreateAngelOfSanctions() {
            var result = new Card();

            result.Legality = new CardLegality()
            {
                Commander = true,
                Modern = true,
                Standard = true,
                Vintage = true
            };

            result.Name = "Angel of Sanctions";
            result.Manacost = new ManaCost();
            result.Manacost.ColorCost = new List<ColorCost>();
            result.Manacost.ColorCost.Add(new ColorCost() { Amount = 3, Color = Color.NoColor });
            result.Manacost.ColorCost.Add(new ColorCost() { Amount = 2, Color = Color.White });

            result.MainType = new List<CardType>();
            result.MainType.Add(new CardType() { Name = "Creature" });

            result.SubType = new List<CardType>();
            result.SubType.Add(new CardType() { Name = "Angel" });

            result.CardSet = new CardSet();
            result.CardSet.Name = "Amonkhet";
            result.CardSet.Year = 2017;
            result.CardSet.Block = "Amonkhet";

            result.Rarity = CardRarity.Rare;

            result.Abilities = new List<Ability>();
            result.Abilities.Add(new Ability()
            {
                Description = "Flying",
                Effects = new List<AbilityEffect>() {
                    new AbilityEffect(){
                        EffectType = AbilityEffectType.Flying,
                        TimeSpan = AbilityEffectTimeSpan.Forever,
                        Target = AbilityEffectTarget.None,
                        TargetPlayer = AbilityEffectTargetPlayer.None
                    }
                }
            });

            result.Abilities.Add(new Ability()
            {
                Description = "When Angel of Sanctions enters the battlefield, you may exile target nonland permanent an opponent controls until Angel of Sanctions leaves the battlefield. ",
                Effects = new List<AbilityEffect>() {
                    new AbilityEffect(){
                        EffectType = AbilityEffectType.EnterTheBattleField,
                        Target = AbilityEffectTarget.ThisCard
                    },
                    new AbilityEffect(){
                        EffectType = AbilityEffectType.ExileTargetNonlandPermanent,
                        Target = AbilityEffectTarget.Permanent,
                        TargetPlayer = AbilityEffectTargetPlayer.Opponent,
                        TimeSpan = AbilityEffectTimeSpan.LeavesBattlefield
                    }
                },
            });

            result.Abilities.Add(new Ability()
            {
                Name = "Embalm",
                Description = "Embalm 5W (5W, Exile this card from your graveyard: Create a token that's a copy of it, except it's a white Zombie Angel with no mana cost. Embalm only as a sorcery.)",
                ManaCost = new ManaCost()
                {
                    ColorCost = new List<ColorCost>() {
                        new ColorCost(){ Amount = 5, Color = Color.NoColor },
                        new ColorCost(){ Amount = 1, Color = Color.White }
                    }
                },
                Effects = new List<AbilityEffect>() {
                    new AbilityEffect(){
                        EffectType = AbilityEffectType.ExileCreatureCard,
                        Target =  AbilityEffectTarget.ThisCard,
                        Location = AbilityEffectLocation.YourGraveyard,
                        TurnStep = AbilityEffectTimeTrigger.Immediate
                    },
                    new AbilityEffect(){
                        EffectType = AbilityEffectType.CreateATokenCopy,
                        Target = AbilityEffectTarget.ThisCard,
                        Location = AbilityEffectLocation.Battlefield,
                        CreatureToken = new AbilityCreatureToken(){
                            ManaCost = new ManaCost(){
                                ColorCost = new List<ColorCost>(){
                                    new ColorCost(){ Amount = 0, Color = Color.White }
                                }
                            },
                            MainType = new List<CardType>(){
                                new CardType(){ Name = "Creature"}
                            },
                            SubType = new List<CardType>(){
                                new CardType(){ Name = "White" },
                                new CardType(){ Name = "Zombie" },
                                new CardType(){ Name = "Angel" }
                            }
                        }
                    }
                }
            });

        }
    }
}
