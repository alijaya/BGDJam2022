using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event of type `Enemy`. Inherits from `AtomEvent&lt;Enemy&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-cherry")]
    [CreateAssetMenu(menuName = "Unity Atoms/Events/Enemy", fileName = "EnemyEvent")]
    public sealed class EnemyEvent : AtomEvent<Enemy>
    {
    }
}
