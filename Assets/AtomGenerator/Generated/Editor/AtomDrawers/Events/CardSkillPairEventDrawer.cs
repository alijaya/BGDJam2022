#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Event property drawer of type `CardSkillPair`. Inherits from `AtomDrawer&lt;CardSkillPairEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(CardSkillPairEvent))]
    public class CardSkillPairEventDrawer : AtomDrawer<CardSkillPairEvent> { }
}
#endif
