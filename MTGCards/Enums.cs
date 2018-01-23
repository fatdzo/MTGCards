using System;
using System.Collections.Generic;
using System.Text;

namespace MTGCards
{
    //Main source of power for magic cards. 
    public enum Color
    {
        Red,
        Blue,
        Black,
        Green,
        White,
        NoColor
    }

    //Defines the turn step
    public enum TurnStep
    {
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

    //Defines when the ability should fire off
    public enum AbilityEffectTimeTrigger
    {
        None,
        Start,
        Untap,
        Upkeep,
        Draw,
        PrecombatMain,
        CombatStart,
        DeclareAttackers,
        DeclareBlockers,
        DamageFirst,
        DamageDouble,
        CombatEnd,
        PostCombatMain,
        End,
        Cleanup,

        UpkeepStart,

        Immediate
    }

    // How long does the ability last
    public enum AbilityEffectTimeSpan
    {
        None,
        UntilEndOfTurn,
        UntilDeath,
        LeavesBattlefield,
        Forever,
    }

    //Defines if the ability fires off at a certain event like player was dealt damage
    public enum AbilityEffectEvent
    {
        None,
        CreatureDies,
        AnyCreatureDies,
        DealtDamageToPlayer,
        PlayerDealtDamage
    }

    //Identifies the type of an ability effect. From what I imagine the game engine should react according to the effect type
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
        ReturnToHand,
        AllCreaturesLoseIndestructible,
        CreatureDies,
        ExileTargetNonlandPermanent,
        EnterTheBattleField,
        Embalm
    }

    //Defines the target which the ability effects. 
    public enum AbilityEffectTarget
    {
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

    //Defines if the ability affects certain player
    public enum AbilityEffectTargetPlayer
    {
        None,
        Self,
        Opponent,
        EachOpponent,
        AllPlayers
    }

    //Defines where the location of the ability. For example return target card from your graveyard
    public enum AbilityEffectLocation
    {
        Battlefield,
        YourGraveyard,
        OpponentGraveyard,
        AGraveyard,
        Library,
        OwnersHand
    }
}
