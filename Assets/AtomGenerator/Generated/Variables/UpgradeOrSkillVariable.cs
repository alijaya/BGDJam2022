using UnityEngine;
using System;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Variable of type `UpgradeOrSkill`. Inherits from `AtomVariable&lt;UpgradeOrSkill, UpgradeOrSkillPair, UpgradeOrSkillEvent, UpgradeOrSkillPairEvent, UpgradeOrSkillUpgradeOrSkillFunction&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-lush")]
    [CreateAssetMenu(menuName = "Unity Atoms/Variables/UpgradeOrSkill", fileName = "UpgradeOrSkillVariable")]
    public sealed class UpgradeOrSkillVariable : AtomVariable<UpgradeOrSkill, UpgradeOrSkillPair, UpgradeOrSkillEvent, UpgradeOrSkillPairEvent, UpgradeOrSkillUpgradeOrSkillFunction>
    {
        protected override bool ValueEquals(UpgradeOrSkill other)
        {
            return _value == other;
        }
    }
}
