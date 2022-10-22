using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityAtoms.BaseAtoms;

[CreateAssetMenu]
public class GlobalRef : GlobalSO<GlobalRef>
{
    public CharacterStatus playerStatus;
    public CharacterStatus enemyStatus;
    public CardSkillValueList playerSkills;
}