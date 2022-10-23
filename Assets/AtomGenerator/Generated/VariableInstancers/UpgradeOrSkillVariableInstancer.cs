using UnityEngine;
using UnityAtoms.BaseAtoms;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Variable Instancer of type `UpgradeOrSkill`. Inherits from `AtomVariableInstancer&lt;UpgradeOrSkillVariable, UpgradeOrSkillPair, UpgradeOrSkill, UpgradeOrSkillEvent, UpgradeOrSkillPairEvent, UpgradeOrSkillUpgradeOrSkillFunction&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-hotpink")]
    [AddComponentMenu("Unity Atoms/Variable Instancers/UpgradeOrSkill Variable Instancer")]
    public class UpgradeOrSkillVariableInstancer : AtomVariableInstancer<
        UpgradeOrSkillVariable,
        UpgradeOrSkillPair,
        UpgradeOrSkill,
        UpgradeOrSkillEvent,
        UpgradeOrSkillPairEvent,
        UpgradeOrSkillUpgradeOrSkillFunction>
    { }
}
