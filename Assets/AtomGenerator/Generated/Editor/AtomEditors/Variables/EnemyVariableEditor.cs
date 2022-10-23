using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Variable Inspector of type `Enemy`. Inherits from `AtomVariableEditor`
    /// </summary>
    [CustomEditor(typeof(EnemyVariable))]
    public sealed class EnemyVariableEditor : AtomVariableEditor<Enemy, EnemyPair> { }
}
