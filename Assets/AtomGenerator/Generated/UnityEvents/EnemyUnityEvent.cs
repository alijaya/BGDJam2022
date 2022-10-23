using System;
using UnityEngine.Events;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// None generic Unity Event of type `Enemy`. Inherits from `UnityEvent&lt;Enemy&gt;`.
    /// </summary>
    [Serializable]
    public sealed class EnemyUnityEvent : UnityEvent<Enemy> { }
}
