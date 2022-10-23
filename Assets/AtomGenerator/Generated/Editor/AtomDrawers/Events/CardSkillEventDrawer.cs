#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Event property drawer of type `CardSkill`. Inherits from `AtomDrawer&lt;CardSkillEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(CardSkillEvent))]
    public class CardSkillEventDrawer : AtomDrawer<CardSkillEvent> { }
}
#endif
