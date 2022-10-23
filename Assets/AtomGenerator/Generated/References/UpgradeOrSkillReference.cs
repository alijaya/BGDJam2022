using System;
using UnityAtoms.BaseAtoms;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Reference of type `UpgradeOrSkill`. Inherits from `AtomReference&lt;UpgradeOrSkill, UpgradeOrSkillPair, UpgradeOrSkillConstant, UpgradeOrSkillVariable, UpgradeOrSkillEvent, UpgradeOrSkillPairEvent, UpgradeOrSkillUpgradeOrSkillFunction, UpgradeOrSkillVariableInstancer, AtomCollection, AtomList&gt;`.
    /// </summary>
    [Serializable]
    public sealed class UpgradeOrSkillReference : AtomReference<
        UpgradeOrSkill,
        UpgradeOrSkillPair,
        UpgradeOrSkillConstant,
        UpgradeOrSkillVariable,
        UpgradeOrSkillEvent,
        UpgradeOrSkillPairEvent,
        UpgradeOrSkillUpgradeOrSkillFunction,
        UpgradeOrSkillVariableInstancer>, IEquatable<UpgradeOrSkillReference>
    {
        public UpgradeOrSkillReference() : base() { }
        public UpgradeOrSkillReference(UpgradeOrSkill value) : base(value) { }
        public bool Equals(UpgradeOrSkillReference other) { return base.Equals(other); }
        protected override bool ValueEquals(UpgradeOrSkill other)
        {
            throw new NotImplementedException();
        }
    }
}
