#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Constant property drawer of type `UpgradeOrSkill`. Inherits from `AtomDrawer&lt;UpgradeOrSkillConstant&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(UpgradeOrSkillConstant))]
    public class UpgradeOrSkillConstantDrawer : VariableDrawer<UpgradeOrSkillConstant> { }
}
#endif
