using UnityEngine;
using UnityAtoms.BaseAtoms;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Set variable value Action of type `Enemy`. Inherits from `SetVariableValue&lt;Enemy, EnemyPair, EnemyVariable, EnemyConstant, EnemyReference, EnemyEvent, EnemyPairEvent, EnemyVariableInstancer&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-purple")]
    [CreateAssetMenu(menuName = "Unity Atoms/Actions/Set Variable Value/Enemy", fileName = "SetEnemyVariableValue")]
    public sealed class SetEnemyVariableValue : SetVariableValue<
        Enemy,
        EnemyPair,
        EnemyVariable,
        EnemyConstant,
        EnemyReference,
        EnemyEvent,
        EnemyPairEvent,
        EnemyEnemyFunction,
        EnemyVariableInstancer>
    { }
}
