using UnityEngine;
using UnityAtoms.BaseAtoms;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Variable Instancer of type `Enemy`. Inherits from `AtomVariableInstancer&lt;EnemyVariable, EnemyPair, Enemy, EnemyEvent, EnemyPairEvent, EnemyEnemyFunction&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-hotpink")]
    [AddComponentMenu("Unity Atoms/Variable Instancers/Enemy Variable Instancer")]
    public class EnemyVariableInstancer : AtomVariableInstancer<
        EnemyVariable,
        EnemyPair,
        Enemy,
        EnemyEvent,
        EnemyPairEvent,
        EnemyEnemyFunction>
    { }
}
