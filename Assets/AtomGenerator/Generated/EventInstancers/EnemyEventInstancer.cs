using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event Instancer of type `Enemy`. Inherits from `AtomEventInstancer&lt;Enemy, EnemyEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-sign-blue")]
    [AddComponentMenu("Unity Atoms/Event Instancers/Enemy Event Instancer")]
    public class EnemyEventInstancer : AtomEventInstancer<Enemy, EnemyEvent> { }
}
