using System;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event Reference of type `UpgradeOrSkill`. Inherits from `AtomEventReference&lt;UpgradeOrSkill, UpgradeOrSkillVariable, UpgradeOrSkillEvent, UpgradeOrSkillVariableInstancer, UpgradeOrSkillEventInstancer&gt;`.
    /// </summary>
    [Serializable]
    public sealed class UpgradeOrSkillEventReference : AtomEventReference<
        UpgradeOrSkill,
        UpgradeOrSkillVariable,
        UpgradeOrSkillEvent,
        UpgradeOrSkillVariableInstancer,
        UpgradeOrSkillEventInstancer>, IGetEvent 
    { }
}
