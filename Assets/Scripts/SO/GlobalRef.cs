using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityAtoms.BaseAtoms;

[CreateAssetMenu]
public class GlobalRef : GlobalSO<GlobalRef>
{
    public CharacterStatus playerStatus;
    public CharacterStatus enemyStatus;
    public IntReference playerMoney;
    public CardSkillValueList playerSkills;
    public EnemyValueList enemies;
}
