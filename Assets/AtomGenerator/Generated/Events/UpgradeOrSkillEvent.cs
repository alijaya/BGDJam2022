using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event of type `UpgradeOrSkill`. Inherits from `AtomEvent&lt;UpgradeOrSkill&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-cherry")]
    [CreateAssetMenu(menuName = "Unity Atoms/Events/UpgradeOrSkill", fileName = "UpgradeOrSkillEvent")]
    public sealed class UpgradeOrSkillEvent : AtomEvent<UpgradeOrSkill>
    {
    }
}
