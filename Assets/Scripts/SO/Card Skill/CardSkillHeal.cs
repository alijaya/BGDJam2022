using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class CardSkillHeal : CardSkill
{
    public override void DoAction(int diceValue, CharacterStatus attacker, CharacterStatus defender)
    {
        switch (modifierType)
        {
            case ModifierType.Normal: attacker.DoHealed(diceValue); break;
            case ModifierType.Exact: attacker.DoHealed(modifierValue); break;
            case ModifierType.Add: attacker.DoHealed(diceValue + modifierValue); break;
            case ModifierType.Subtract: attacker.DoHealed(diceValue - modifierValue); break;
            case ModifierType.Multiply: attacker.DoHealed(diceValue * modifierValue); break;
            case ModifierType.Divide: attacker.DoHealed(diceValue / modifierValue); break;
        }
    }
}
