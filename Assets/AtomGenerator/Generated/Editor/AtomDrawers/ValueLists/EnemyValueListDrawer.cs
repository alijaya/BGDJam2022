#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Value List property drawer of type `Enemy`. Inherits from `AtomDrawer&lt;EnemyValueList&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(EnemyValueList))]
    public class EnemyValueListDrawer : AtomDrawer<EnemyValueList> { }
}
#endif
