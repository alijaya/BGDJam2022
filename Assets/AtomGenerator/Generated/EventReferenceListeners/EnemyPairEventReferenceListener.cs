using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event Reference Listener of type `EnemyPair`. Inherits from `AtomEventReferenceListener&lt;EnemyPair, EnemyPairEvent, EnemyPairEventReference, EnemyPairUnityEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-orange")]
    [AddComponentMenu("Unity Atoms/Listeners/EnemyPair Event Reference Listener")]
    public sealed class EnemyPairEventReferenceListener : AtomEventReferenceListener<
        EnemyPair,
        EnemyPairEvent,
        EnemyPairEventReference,
        EnemyPairUnityEvent>
    { }
}
