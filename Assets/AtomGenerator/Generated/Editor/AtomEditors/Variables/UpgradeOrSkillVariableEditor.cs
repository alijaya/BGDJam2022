using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Variable Inspector of type `UpgradeOrSkill`. Inherits from `AtomVariableEditor`
    /// </summary>
    [CustomEditor(typeof(UpgradeOrSkillVariable))]
    public sealed class UpgradeOrSkillVariableEditor : AtomVariableEditor<UpgradeOrSkill, UpgradeOrSkillPair> { }
}
