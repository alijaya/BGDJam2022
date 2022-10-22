using UnityEngine;
using UnityAtoms.BaseAtoms;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Variable Instancer of type `CardSkill`. Inherits from `AtomVariableInstancer&lt;CardSkillVariable, CardSkillPair, CardSkill, CardSkillEvent, CardSkillPairEvent, CardSkillCardSkillFunction&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-hotpink")]
    [AddComponentMenu("Unity Atoms/Variable Instancers/CardSkill Variable Instancer")]
    public class CardSkillVariableInstancer : AtomVariableInstancer<
        CardSkillVariable,
        CardSkillPair,
        CardSkill,
        CardSkillEvent,
        CardSkillPairEvent,
        CardSkillCardSkillFunction>
    { }
}
