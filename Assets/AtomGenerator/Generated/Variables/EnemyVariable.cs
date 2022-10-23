using UnityEngine;
using System;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Variable of type `Enemy`. Inherits from `AtomVariable&lt;Enemy, EnemyPair, EnemyEvent, EnemyPairEvent, EnemyEnemyFunction&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-lush")]
    [CreateAssetMenu(menuName = "Unity Atoms/Variables/Enemy", fileName = "EnemyVariable")]
    public sealed class EnemyVariable : AtomVariable<Enemy, EnemyPair, EnemyEvent, EnemyPairEvent, EnemyEnemyFunction>
    {
        protected override bool ValueEquals(Enemy other)
        {
            return _value == other;
        }
    }
}
