#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Constant property drawer of type `Enemy`. Inherits from `AtomDrawer&lt;EnemyConstant&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(EnemyConstant))]
    public class EnemyConstantDrawer : VariableDrawer<EnemyConstant> { }
}
#endif
