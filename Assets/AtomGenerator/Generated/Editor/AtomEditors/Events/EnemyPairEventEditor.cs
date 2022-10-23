#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityEngine.UIElements;
using UnityAtoms.Editor;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Event property drawer of type `EnemyPair`. Inherits from `AtomEventEditor&lt;EnemyPair, EnemyPairEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomEditor(typeof(EnemyPairEvent))]
    public sealed class EnemyPairEventEditor : AtomEventEditor<EnemyPair, EnemyPairEvent> { }
}
#endif
