using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class CardSkill : ScriptableObject
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

    public string title = "";
    public string description = "";

    public bool repeatable = false;

    public RequirementType requirementType = RequirementType.Normal;
    public int requirementValue = 0; // ignored if Normal, Odd, Even, Pair

    public ModifierType modifierType = ModifierType.Normal;
    public int modifierValue = 0;

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
}
