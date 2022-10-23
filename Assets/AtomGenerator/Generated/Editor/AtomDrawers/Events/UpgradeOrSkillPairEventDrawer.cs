#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Event property drawer of type `UpgradeOrSkillPair`. Inherits from `AtomDrawer&lt;UpgradeOrSkillPairEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(UpgradeOrSkillPairEvent))]
    public class UpgradeOrSkillPairEventDrawer : AtomDrawer<UpgradeOrSkillPairEvent> { }
}
#endif
