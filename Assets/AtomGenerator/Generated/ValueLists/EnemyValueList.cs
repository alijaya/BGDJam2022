using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Value List of type `Enemy`. Inherits from `AtomValueList&lt;Enemy, EnemyEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-piglet")]
    [CreateAssetMenu(menuName = "Unity Atoms/Value Lists/Enemy", fileName = "EnemyValueList")]
    public sealed class EnemyValueList : AtomValueList<Enemy, EnemyEvent> { }
}
