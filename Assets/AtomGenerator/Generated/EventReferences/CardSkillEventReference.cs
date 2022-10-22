using System;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event Reference of type `CardSkill`. Inherits from `AtomEventReference&lt;CardSkill, CardSkillVariable, CardSkillEvent, CardSkillVariableInstancer, CardSkillEventInstancer&gt;`.
    /// </summary>
    [Serializable]
    public sealed class CardSkillEventReference : AtomEventReference<
        CardSkill,
        CardSkillVariable,
        CardSkillEvent,
        CardSkillVariableInstancer,
        CardSkillEventInstancer>, IGetEvent 
    { }
}
