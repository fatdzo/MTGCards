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

        public CardCost Cost;

        public List<CardType> MainType;
        public List<CardType> SubType;

        public int Power;
        public int Toughness;

        public List<Ability> Abilities;

        public Card() {
        }
    }

    public enum Color {
        Red,
        Blue,
        Black,
        Green,
        White,
        NoColor
    }

    

    public enum TurnStep {
        Start,
        Untap,
        Upkeep,
        Draw,
        PrecombatMain,
        CombatStart,
        DeclareAttackers,
        DeclareBlockers,
        DamageFirst,
        DamageSecond,
        CombatEnd,
        PostCombatMain,
        End,
        Cleanup
    }

    public enum AbilityEffectTimeTrigger {
        None,
        Start,
        Untap,
        Upkeep,
        Draw,
        PrecombatMain,
        CombatStart,
        DeclareAttackers,
        DeclareBlockers,
        Damage,
        CombatEnd,
        PostCombatMain,
        End,
        Cleanup,

        UpkeepStart,
        
        Immediate
    }

    public enum AbilityEffectTimeSpan {
        None,
        UntilEndOfTurn,
        UntilDeath,
        LeavesBattlefield,
        Forever,
    }

    public enum AbilityEffectEvent {
        None,
        ThisCreatureDies,
        AnyCreatureDies,
        DealtDamageToPlayer,
        PlayerDealtDamage
    }

    public enum AbilityEffectType
    {
        None,
        Flying,
        Vigilance,
        Trample,
        Haste,
        DoubleStrike,

        EachOpponentLoseLife,
        PlayerGainsLife,
        Scry,
        ExileCreatureCard,
        ExileCard,
        CreateAToken,
        CreateATokenCopy,
        ReturnToOwnersHand,
        AllCreaturesLoseIndestructible,

        ExileTargetNonlandPermanent,

        Embalm
    }

    public enum AbilityEffectTarget {
        None,
        ThisCard,
        Creature,
        Instant,
        Sorcery,
        Planeswalker,
        Permanent,
        Artifact,
        AllCreatures,
        AllArtifacts,
        AllPermanents,
        AllPlaneswalkers
    }

    public enum AbilityEffectTargetPlayer {
        None,
        Self,
        Opponent
    }

    public enum AbilityEffectLocation {
        Battlefield,
        YourGraveyard,
        OpponentGraveyard,
        AGraveyard,
        Library
    }
}
