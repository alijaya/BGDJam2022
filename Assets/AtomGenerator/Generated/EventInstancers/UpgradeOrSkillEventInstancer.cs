using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event Instancer of type `UpgradeOrSkill`. Inherits from `AtomEventInstancer&lt;UpgradeOrSkill, UpgradeOrSkillEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-sign-blue")]
    [AddComponentMenu("Unity Atoms/Event Instancers/UpgradeOrSkill Event Instancer")]
    public class UpgradeOrSkillEventInstancer : AtomEventInstancer<UpgradeOrSkill, UpgradeOrSkillEvent> { }
}
