#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Variable property drawer of type `UpgradeOrSkill`. Inherits from `AtomDrawer&lt;UpgradeOrSkillVariable&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(UpgradeOrSkillVariable))]
    public class UpgradeOrSkillVariableDrawer : VariableDrawer<UpgradeOrSkillVariable> { }
}
#endif
