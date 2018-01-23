using System;
using System.Collections.Generic;
using System.Text;

namespace MTGCards
{
    public class AbilityCreatureToken
    {
        public int Power;
        public int Toughness;
        public List<CardType> MainType;
        public List<CardType> SubType;
        public CardCost ManaCost;
    }
}
