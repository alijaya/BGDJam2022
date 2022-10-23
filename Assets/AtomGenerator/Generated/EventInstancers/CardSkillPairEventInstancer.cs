using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event Instancer of type `CardSkillPair`. Inherits from `AtomEventInstancer&lt;CardSkillPair, CardSkillPairEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-sign-blue")]
    [AddComponentMenu("Unity Atoms/Event Instancers/CardSkillPair Event Instancer")]
    public class CardSkillPairEventInstancer : AtomEventInstancer<CardSkillPair, CardSkillPairEvent> { }
}
