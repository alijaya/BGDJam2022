using System;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event Reference of type `EnemyPair`. Inherits from `AtomEventReference&lt;EnemyPair, EnemyVariable, EnemyPairEvent, EnemyVariableInstancer, EnemyPairEventInstancer&gt;`.
    /// </summary>
    [Serializable]
    public sealed class EnemyPairEventReference : AtomEventReference<
        EnemyPair,
        EnemyVariable,
        EnemyPairEvent,
        EnemyVariableInstancer,
        EnemyPairEventInstancer>, IGetEvent 
    { }
}
