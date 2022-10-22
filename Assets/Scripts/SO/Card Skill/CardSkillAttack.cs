using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class CardSkillAttack : CardSkill
{
    public override void DoAction(int diceValue, CharacterStatus attacker, CharacterStatus defender)
    {
        switch(modifierType)
        {
            case ModifierType.Normal: defender.DoDamaged(diceValue); break;
            case ModifierType.Exact: defender.DoDamaged(modifierValue); break;
            case ModifierType.Add: defender.DoDamaged(diceValue + modifierValue); break;
            case ModifierType.Subtract: defender.DoDamaged(diceValue - modifierValue); break;
            case ModifierType.Multiply: defender.DoDamaged(diceValue * modifierValue); break;
            case ModifierType.Divide: defender.DoDamaged(diceValue / modifierValue); break;
        }
    }
}
