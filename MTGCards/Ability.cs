using System;
using System.Collections.Generic;
using System.Text;

namespace MTGCards
{
    public class Ability
    {
        public string Name;
        public string Description;
        public ManaCost ManaCost;
        //Do we need to tap the card for the ability to trigger
        public bool RequiresTap = false;

        public int X;
        public List<AbilityEffect> Effects;
    }
}
