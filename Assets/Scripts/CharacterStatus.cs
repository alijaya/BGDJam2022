using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityAtoms.BaseAtoms;

[CreateAssetMenu]
public class CharacterStatus : ScriptableObject
{
    public IntReference currentHP;
    public IntReference maxHP;

    public void DoDamaged(int damage)
    {
        currentHP.Value -= damage;
    }

    public void DoHealed(int damage)
    {
        currentHP.Value += damage;
    }
}
