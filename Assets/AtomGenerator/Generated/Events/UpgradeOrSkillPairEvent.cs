using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event of type `UpgradeOrSkillPair`. Inherits from `AtomEvent&lt;UpgradeOrSkillPair&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-cherry")]
    [CreateAssetMenu(menuName = "Unity Atoms/Events/UpgradeOrSkillPair", fileName = "UpgradeOrSkillPairEvent")]
    public sealed class UpgradeOrSkillPairEvent : AtomEvent<UpgradeOrSkillPair>
    {
    }
}
