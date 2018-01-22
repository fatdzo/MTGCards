using System;
using System.Collections.Generic;
using System.Text;

namespace MTGCards
{
    public class Ability
    {
        public string Name;
        public string Description;
        public CardCost ManaCost;
        public int X;
        public List<AbilityEffect> Effects;
    }
}
