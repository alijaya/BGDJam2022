using System;
using UnityAtoms.BaseAtoms;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Reference of type `CardSkill`. Inherits from `AtomReference&lt;CardSkill, CardSkillPair, CardSkillConstant, CardSkillVariable, CardSkillEvent, CardSkillPairEvent, CardSkillCardSkillFunction, CardSkillVariableInstancer, AtomCollection, AtomList&gt;`.
    /// </summary>
    [Serializable]
    public sealed class CardSkillReference : AtomReference<
        CardSkill,
        CardSkillPair,
        CardSkillConstant,
        CardSkillVariable,
        CardSkillEvent,
        CardSkillPairEvent,
        CardSkillCardSkillFunction,
        CardSkillVariableInstancer>, IEquatable<CardSkillReference>
    {
        public CardSkillReference() : base() { }
        public CardSkillReference(CardSkill value) : base(value) { }
        public bool Equals(CardSkillReference other) { return base.Equals(other); }
        protected override bool ValueEquals(CardSkill other)
        {
            throw new NotImplementedException();
        }
    }
}
