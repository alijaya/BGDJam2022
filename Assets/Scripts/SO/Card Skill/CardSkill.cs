using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class CardSkill : ScriptableObject, System.IEquatable<CardSkill>
{
    public enum RequirementType
    {
        Normal,
        Exact,
        Max,
        Min,
        Odd,
        Even,
        //Pair,
        //Countdown
    }

    public enum ModifierType
    {
        Normal,
        Exact,
        Add,
        Subtract,
        Multiply,
        Divide,
    }

    public enum RepeatType
    {
        Normal, // Turn 1
        Repeatable,
        TurnCount,
        BattleCount,
    }

    public string title = "";
    public string description = "";
    public int price = 0;

    public RequirementType requirementType = RequirementType.Normal;
    public int requirementValue = 0; // ignored if Normal, Odd, Even, Pair

    public ModifierType modifierType = ModifierType.Normal;
    public int modifierValue = 0;

    public RepeatType repeatType = RepeatType.Normal;
    public int repeatValue = 1;

    public bool IsUsable(int usageInTurn, int usageInBattle)
    {
        switch (repeatType)
        {
            case CardSkill.RepeatType.Normal: return usageInTurn == 0; 
            case CardSkill.RepeatType.Repeatable: return true;
            case CardSkill.RepeatType.TurnCount: return usageInTurn < repeatValue;
            case CardSkill.RepeatType.BattleCount: return usageInBattle < repeatValue;
            default: return false;
        }
    }

    public bool TestDice(int diceValue)
    {
        switch(requirementType)
        {
            case RequirementType.Normal: return true;
            case RequirementType.Exact: return diceValue == requirementValue;
            case RequirementType.Max: return diceValue <= requirementValue;
            case RequirementType.Min: return diceValue >= requirementValue;
            case RequirementType.Odd: return diceValue % 2 == 1;
            case RequirementType.Even: return diceValue % 2 == 0;
            default: return false;
        }
    }

    public bool DoActionWithTest(int diceValue, CharacterStatus attacker, CharacterStatus defender)
    {
        if (TestDice(diceValue))
        {
            DoAction(diceValue, attacker, defender);
            return true;
        }
        else
        {
            return false;
        }
    }

    public virtual void DoAction(int diceValue, CharacterStatus attacker, CharacterStatus defender)
    {
        defender.DoDamaged(diceValue);
    }

    public bool Equals(CardSkill other)
    {
        return this == other;
    }
}
