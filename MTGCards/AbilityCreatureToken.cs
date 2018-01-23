using System;
using System.Collections.Generic;
using System.Text;

namespace MTGCards
{
    public class AbilityCreatureToken
    {
        public int NumOfTokensToCreate = 0;
        public int Power;
        public int Toughness;
        public List<CardType> MainType;
        public List<CardType> SubType;
        public ManaCost ManaCost;
        public List<Ability> Abilities;
    }
}
