#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Variable property drawer of type `Enemy`. Inherits from `AtomDrawer&lt;EnemyVariable&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(EnemyVariable))]
    public class EnemyVariableDrawer : VariableDrawer<EnemyVariable> { }
}
#endif
