#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Variable property drawer of type `CardSkill`. Inherits from `AtomDrawer&lt;CardSkillVariable&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(CardSkillVariable))]
    public class CardSkillVariableDrawer : VariableDrawer<CardSkillVariable> { }
}
#endif
