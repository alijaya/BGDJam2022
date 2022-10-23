#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityEngine.UIElements;
using UnityAtoms.Editor;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Event property drawer of type `CardSkill`. Inherits from `AtomEventEditor&lt;CardSkill, CardSkillEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomEditor(typeof(CardSkillEvent))]
    public sealed class CardSkillEventEditor : AtomEventEditor<CardSkill, CardSkillEvent> { }
}
#endif
