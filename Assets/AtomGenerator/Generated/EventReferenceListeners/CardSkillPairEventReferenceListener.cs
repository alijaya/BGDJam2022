using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event Reference Listener of type `CardSkillPair`. Inherits from `AtomEventReferenceListener&lt;CardSkillPair, CardSkillPairEvent, CardSkillPairEventReference, CardSkillPairUnityEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-orange")]
    [AddComponentMenu("Unity Atoms/Listeners/CardSkillPair Event Reference Listener")]
    public sealed class CardSkillPairEventReferenceListener : AtomEventReferenceListener<
        CardSkillPair,
        CardSkillPairEvent,
        CardSkillPairEventReference,
        CardSkillPairUnityEvent>
    { }
}
