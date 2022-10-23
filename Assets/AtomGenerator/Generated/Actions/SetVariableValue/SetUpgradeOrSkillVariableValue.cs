using UnityEngine;
using UnityAtoms.BaseAtoms;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Set variable value Action of type `UpgradeOrSkill`. Inherits from `SetVariableValue&lt;UpgradeOrSkill, UpgradeOrSkillPair, UpgradeOrSkillVariable, UpgradeOrSkillConstant, UpgradeOrSkillReference, UpgradeOrSkillEvent, UpgradeOrSkillPairEvent, UpgradeOrSkillVariableInstancer&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-purple")]
    [CreateAssetMenu(menuName = "Unity Atoms/Actions/Set Variable Value/UpgradeOrSkill", fileName = "SetUpgradeOrSkillVariableValue")]
    public sealed class SetUpgradeOrSkillVariableValue : SetVariableValue<
        UpgradeOrSkill,
        UpgradeOrSkillPair,
        UpgradeOrSkillVariable,
        UpgradeOrSkillConstant,
        UpgradeOrSkillReference,
        UpgradeOrSkillEvent,
        UpgradeOrSkillPairEvent,
        UpgradeOrSkillUpgradeOrSkillFunction,
        UpgradeOrSkillVariableInstancer>
    { }
}
