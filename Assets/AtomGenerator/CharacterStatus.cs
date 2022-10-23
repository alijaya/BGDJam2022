using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityAtoms.BaseAtoms;

[CreateAssetMenu]
public class CharacterStatus : ScriptableObject
{
    public IntReference currentHP;
    public IntReference maxHP;
    public IntReference playerMoney;
    public VoidBaseEventReference deathEvent;

    public void DoDamaged(int damage)
    {
        currentHP.Value -= damage;
        if (currentHP.Value <= 0)
        {
            deathEvent.Event.Raise();
        }
    }

    public void DoHealed(int damage)
    {
        currentHP.Value += damage;
    }

    public void DoDecMoney(int money)
    {
        playerMoney.Value -= money;
    }

    public void DoIncMoney(int money)
    {
        playerMoney.Value += money;
    }
}
