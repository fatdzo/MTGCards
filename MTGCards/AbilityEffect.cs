using System;
using System.Collections.Generic;
using System.Text;

namespace MTGCards
{
    public class AbilityEffect
    {
        //ex. creature losses flying
        public bool IsSuppressed;

        public AbilityEffectType EffectType;
        public AbilityEffectTimeTrigger Time;
        public AbilityEffectEvent Event;
        public AbilityEffectTarget Target;
        public AbilityEffectTimeSpan TimeSpan;
        public AbilityEffectTargetPlayer TargetPlayer;
        public AbilityEffectLocation Location;
        public int X;
        public AbilityCreatureToken CreatureToken;
    }
}
