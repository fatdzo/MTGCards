using System;
using System.Collections.Generic;
using System.Text;

namespace MTGCards
{
    public class AbilityEffect
    {
        public bool IsTriggered;
        public AbilityEffectTimeTrigger Time;
        public AbilityEffectEvent Event;
        public AbilityEffectType EffectType;
        public AbilityEffectTarget Target;
        public AbilityEffectTimeSpan TimeSpan;
        public AbilityEffectTargetPlayer TargetPlayer;
        public AbilityEffectLocation Location;
        public int X;
        public int Power;
        public int Toughness;
        public List<CardType> MainType;
        public List<CardType> SubType;
        public CardCost ManaCost;
    }
}
