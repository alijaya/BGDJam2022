using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event Reference Listener of type `CardSkill`. Inherits from `AtomEventReferenceListener&lt;CardSkill, CardSkillEvent, CardSkillEventReference, CardSkillUnityEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-orange")]
    [AddComponentMenu("Unity Atoms/Listeners/CardSkill Event Reference Listener")]
    public sealed class CardSkillEventReferenceListener : AtomEventReferenceListener<
        CardSkill,
        CardSkillEvent,
        CardSkillEventReference,
        CardSkillUnityEvent>
    { }
}
