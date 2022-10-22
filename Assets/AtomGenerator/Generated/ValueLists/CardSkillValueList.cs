using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Value List of type `CardSkill`. Inherits from `AtomValueList&lt;CardSkill, CardSkillEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-piglet")]
    [CreateAssetMenu(menuName = "Unity Atoms/Value Lists/CardSkill", fileName = "CardSkillValueList")]
    public sealed class CardSkillValueList : AtomValueList<CardSkill, CardSkillEvent> { }
}
