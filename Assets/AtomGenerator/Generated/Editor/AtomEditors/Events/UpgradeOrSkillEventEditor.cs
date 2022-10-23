#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityEngine.UIElements;
using UnityAtoms.Editor;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Event property drawer of type `UpgradeOrSkill`. Inherits from `AtomEventEditor&lt;UpgradeOrSkill, UpgradeOrSkillEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomEditor(typeof(UpgradeOrSkillEvent))]
    public sealed class UpgradeOrSkillEventEditor : AtomEventEditor<UpgradeOrSkill, UpgradeOrSkillEvent> { }
}
#endif
