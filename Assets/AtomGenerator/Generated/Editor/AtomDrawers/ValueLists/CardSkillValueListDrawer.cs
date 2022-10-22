#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Value List property drawer of type `CardSkill`. Inherits from `AtomDrawer&lt;CardSkillValueList&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(CardSkillValueList))]
    public class CardSkillValueListDrawer : AtomDrawer<CardSkillValueList> { }
}
#endif
