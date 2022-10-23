#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityEngine.UIElements;
using UnityAtoms.Editor;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Event property drawer of type `UpgradeOrSkillPair`. Inherits from `AtomEventEditor&lt;UpgradeOrSkillPair, UpgradeOrSkillPairEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomEditor(typeof(UpgradeOrSkillPairEvent))]
    public sealed class UpgradeOrSkillPairEventEditor : AtomEventEditor<UpgradeOrSkillPair, UpgradeOrSkillPairEvent> { }
}
#endif
