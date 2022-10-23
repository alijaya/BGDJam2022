#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Constant property drawer of type `CardSkill`. Inherits from `AtomDrawer&lt;CardSkillConstant&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(CardSkillConstant))]
    public class CardSkillConstantDrawer : VariableDrawer<CardSkillConstant> { }
}
#endif
