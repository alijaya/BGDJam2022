using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Variable Inspector of type `CardSkill`. Inherits from `AtomVariableEditor`
    /// </summary>
    [CustomEditor(typeof(CardSkillVariable))]
    public sealed class CardSkillVariableEditor : AtomVariableEditor<CardSkill, CardSkillPair> { }
}
