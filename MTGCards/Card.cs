using System;
using System.Collections.Generic;
using System.Text;

namespace MTGCards
{
    public class Card
    {
        public CardLegality Legality;
        public string Name;
        public string Description;
        public string FlavorText;

        public CardSet CardSet;

        public CardRarity Rarity;

        public ManaCost Manacost;

        public List<CardType> MainType;
        public List<CardType> SubType;

        public int? Power;
        public int? Toughness;
        //In case the card type is a planeswalker
        public int? Loyalty;

        public List<Ability> Abilities;
    }
}
