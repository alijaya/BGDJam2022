using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event of type `EnemyPair`. Inherits from `AtomEvent&lt;EnemyPair&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-cherry")]
    [CreateAssetMenu(menuName = "Unity Atoms/Events/EnemyPair", fileName = "EnemyPairEvent")]
    public sealed class EnemyPairEvent : AtomEvent<EnemyPair>
    {
    }
}
