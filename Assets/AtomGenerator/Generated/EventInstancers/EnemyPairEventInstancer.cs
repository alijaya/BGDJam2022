using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event Instancer of type `EnemyPair`. Inherits from `AtomEventInstancer&lt;EnemyPair, EnemyPairEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-sign-blue")]
    [AddComponentMenu("Unity Atoms/Event Instancers/EnemyPair Event Instancer")]
    public class EnemyPairEventInstancer : AtomEventInstancer<EnemyPair, EnemyPairEvent> { }
}
