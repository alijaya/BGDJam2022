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
        Pair,
        Countdown
    }

    public string title = "";
    public string description = "";

    public bool repeatable = false;

    public RequirementType requirementType = RequirementType.Normal;
    public int requirementValue = 0; // ignored if Normal, Odd, Even, Pair

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

    public void DoActionWithTest(int diceValue, CharacterStatus attacker, CharacterStatus defender)
    {
        if (TestDice(diceValue))
        {
            DoAction(diceValue, attacker, defender);
        }
    }

    public void DoAction(int diceValue, CharacterStatus attacker, CharacterStatus defender)
    {
        defender.currentHP.Value -= diceValue;
    }
}