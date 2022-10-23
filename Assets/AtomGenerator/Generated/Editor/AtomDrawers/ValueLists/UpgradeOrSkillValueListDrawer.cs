#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Value List property drawer of type `UpgradeOrSkill`. Inherits from `AtomDrawer&lt;UpgradeOrSkillValueList&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(UpgradeOrSkillValueList))]
    public class UpgradeOrSkillValueListDrawer : AtomDrawer<UpgradeOrSkillValueList> { }
}
#endif
