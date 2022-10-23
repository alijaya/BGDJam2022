using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event Reference Listener of type `UpgradeOrSkillPair`. Inherits from `AtomEventReferenceListener&lt;UpgradeOrSkillPair, UpgradeOrSkillPairEvent, UpgradeOrSkillPairEventReference, UpgradeOrSkillPairUnityEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-orange")]
    [AddComponentMenu("Unity Atoms/Listeners/UpgradeOrSkillPair Event Reference Listener")]
    public sealed class UpgradeOrSkillPairEventReferenceListener : AtomEventReferenceListener<
        UpgradeOrSkillPair,
        UpgradeOrSkillPairEvent,
        UpgradeOrSkillPairEventReference,
        UpgradeOrSkillPairUnityEvent>
    { }
}
