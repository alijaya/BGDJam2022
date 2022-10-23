using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event Reference Listener of type `Enemy`. Inherits from `AtomEventReferenceListener&lt;Enemy, EnemyEvent, EnemyEventReference, EnemyUnityEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-orange")]
    [AddComponentMenu("Unity Atoms/Listeners/Enemy Event Reference Listener")]
    public sealed class EnemyEventReferenceListener : AtomEventReferenceListener<
        Enemy,
        EnemyEvent,
        EnemyEventReference,
        EnemyUnityEvent>
    { }
}
