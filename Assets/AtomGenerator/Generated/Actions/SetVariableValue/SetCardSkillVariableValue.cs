using UnityEngine;
using UnityAtoms.BaseAtoms;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Set variable value Action of type `CardSkill`. Inherits from `SetVariableValue&lt;CardSkill, CardSkillPair, CardSkillVariable, CardSkillConstant, CardSkillReference, CardSkillEvent, CardSkillPairEvent, CardSkillVariableInstancer&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-purple")]
    [CreateAssetMenu(menuName = "Unity Atoms/Actions/Set Variable Value/CardSkill", fileName = "SetCardSkillVariableValue")]
    public sealed class SetCardSkillVariableValue : SetVariableValue<
        CardSkill,
        CardSkillPair,
        CardSkillVariable,
        CardSkillConstant,
        CardSkillReference,
        CardSkillEvent,
        CardSkillPairEvent,
        CardSkillCardSkillFunction,
        CardSkillVariableInstancer>
    { }
}
