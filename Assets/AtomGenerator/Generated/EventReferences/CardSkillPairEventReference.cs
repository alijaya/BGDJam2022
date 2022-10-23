using System;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event Reference of type `CardSkillPair`. Inherits from `AtomEventReference&lt;CardSkillPair, CardSkillVariable, CardSkillPairEvent, CardSkillVariableInstancer, CardSkillPairEventInstancer&gt;`.
    /// </summary>
    [Serializable]
    public sealed class CardSkillPairEventReference : AtomEventReference<
        CardSkillPair,
        CardSkillVariable,
        CardSkillPairEvent,
        CardSkillVariableInstancer,
        CardSkillPairEventInstancer>, IGetEvent 
    { }
}
