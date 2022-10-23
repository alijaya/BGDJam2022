using System;
using UnityEngine.Events;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// None generic Unity Event of type `EnemyPair`. Inherits from `UnityEvent&lt;EnemyPair&gt;`.
    /// </summary>
    [Serializable]
    public sealed class EnemyPairUnityEvent : UnityEvent<EnemyPair> { }
}
