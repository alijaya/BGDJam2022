using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event Reference Listener of type `UpgradeOrSkill`. Inherits from `AtomEventReferenceListener&lt;UpgradeOrSkill, UpgradeOrSkillEvent, UpgradeOrSkillEventReference, UpgradeOrSkillUnityEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-orange")]
    [AddComponentMenu("Unity Atoms/Listeners/UpgradeOrSkill Event Reference Listener")]
    public sealed class UpgradeOrSkillEventReferenceListener : AtomEventReferenceListener<
        UpgradeOrSkill,
        UpgradeOrSkillEvent,
        UpgradeOrSkillEventReference,
        UpgradeOrSkillUnityEvent>
    { }
}
