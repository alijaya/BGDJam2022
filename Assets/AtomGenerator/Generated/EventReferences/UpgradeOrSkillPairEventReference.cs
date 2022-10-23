using System;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event Reference of type `UpgradeOrSkillPair`. Inherits from `AtomEventReference&lt;UpgradeOrSkillPair, UpgradeOrSkillVariable, UpgradeOrSkillPairEvent, UpgradeOrSkillVariableInstancer, UpgradeOrSkillPairEventInstancer&gt;`.
    /// </summary>
    [Serializable]
    public sealed class UpgradeOrSkillPairEventReference : AtomEventReference<
        UpgradeOrSkillPair,
        UpgradeOrSkillVariable,
        UpgradeOrSkillPairEvent,
        UpgradeOrSkillVariableInstancer,
        UpgradeOrSkillPairEventInstancer>, IGetEvent 
    { }
}
