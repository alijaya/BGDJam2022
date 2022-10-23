using System;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event Reference of type `Enemy`. Inherits from `AtomEventReference&lt;Enemy, EnemyVariable, EnemyEvent, EnemyVariableInstancer, EnemyEventInstancer&gt;`.
    /// </summary>
    [Serializable]
    public sealed class EnemyEventReference : AtomEventReference<
        Enemy,
        EnemyVariable,
        EnemyEvent,
        EnemyVariableInstancer,
        EnemyEventInstancer>, IGetEvent 
    { }
}
