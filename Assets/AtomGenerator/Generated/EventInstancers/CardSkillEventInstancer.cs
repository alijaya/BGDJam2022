using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event Instancer of type `CardSkill`. Inherits from `AtomEventInstancer&lt;CardSkill, CardSkillEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-sign-blue")]
    [AddComponentMenu("Unity Atoms/Event Instancers/CardSkill Event Instancer")]
    public class CardSkillEventInstancer : AtomEventInstancer<CardSkill, CardSkillEvent> { }
}
