using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Constant of type `Enemy`. Inherits from `AtomBaseVariable&lt;Enemy&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-teal")]
    [CreateAssetMenu(menuName = "Unity Atoms/Constants/Enemy", fileName = "EnemyConstant")]
    public sealed class EnemyConstant : AtomBaseVariable<Enemy> { }
}
