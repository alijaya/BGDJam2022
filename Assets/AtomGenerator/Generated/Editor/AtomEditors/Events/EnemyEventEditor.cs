#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityEngine.UIElements;
using UnityAtoms.Editor;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Event property drawer of type `Enemy`. Inherits from `AtomEventEditor&lt;Enemy, EnemyEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomEditor(typeof(EnemyEvent))]
    public sealed class EnemyEventEditor : AtomEventEditor<Enemy, EnemyEvent> { }
}
#endif
