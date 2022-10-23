using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityAtoms.BaseAtoms;

[CreateAssetMenu]
public class CharacterStatus : ScriptableObject
{
    public StringReference title;
    public IntReference currentHP;
    public IntReference maxHP;
    public IntReference diceCount;
    public VoidBaseEventReference deathEvent;

    public void FullHP()
    {
        currentHP.Value = maxHP.Value;
    }

    public void DoDamaged(int damage)
    {
        GlobalRef.instance.PlaySFXAttack();
        currentHP.Value -= damage;
        if (currentHP.Value <= 0)
        {
            deathEvent.Event.Raise();
        }
    }

    public void DoHealed(int damage)
    {
        GlobalRef.instance.PlaySFXHeal();
        currentHP.Value += damage;
    }

    public void DoUpgradeMaxHealth(int health)
    {
        GlobalRef.instance.PlaySFXHeal();
        maxHP.Value += health;
        currentHP.Value += health;
    }

    public void DoUpgradeDice(int count)
    {
        diceCount.Value += count;
    }
}
