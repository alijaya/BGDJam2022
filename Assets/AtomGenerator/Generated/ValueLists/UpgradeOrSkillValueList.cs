using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Value List of type `UpgradeOrSkill`. Inherits from `AtomValueList&lt;UpgradeOrSkill, UpgradeOrSkillEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-piglet")]
    [CreateAssetMenu(menuName = "Unity Atoms/Value Lists/UpgradeOrSkill", fileName = "UpgradeOrSkillValueList")]
    public sealed class UpgradeOrSkillValueList : AtomValueList<UpgradeOrSkill, UpgradeOrSkillEvent> { }
}
