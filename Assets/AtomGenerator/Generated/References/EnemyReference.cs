using System;
using UnityAtoms.BaseAtoms;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Reference of type `Enemy`. Inherits from `AtomReference&lt;Enemy, EnemyPair, EnemyConstant, EnemyVariable, EnemyEvent, EnemyPairEvent, EnemyEnemyFunction, EnemyVariableInstancer, AtomCollection, AtomList&gt;`.
    /// </summary>
    [Serializable]
    public sealed class EnemyReference : AtomReference<
        Enemy,
        EnemyPair,
        EnemyConstant,
        EnemyVariable,
        EnemyEvent,
        EnemyPairEvent,
        EnemyEnemyFunction,
        EnemyVariableInstancer>, IEquatable<EnemyReference>
    {
        public EnemyReference() : base() { }
        public EnemyReference(Enemy value) : base(value) { }
        public bool Equals(EnemyReference other) { return base.Equals(other); }
        protected override bool ValueEquals(Enemy other)
        {
            throw new NotImplementedException();
        }
    }
}
