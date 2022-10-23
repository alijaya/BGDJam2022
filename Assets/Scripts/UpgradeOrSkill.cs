using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class UpgradeOrSkill
{
    public enum UpgradeOrSkillType
    {
        Upgrade,
        Skill
    }

    public UpgradeOrSkillType type;
    public Upgrade upgrade;
    public CardSkill skill;
}
