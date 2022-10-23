using System;
using UnityEngine;
namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// IPair of type `&lt;Enemy&gt;`. Inherits from `IPair&lt;Enemy&gt;`.
    /// </summary>
    [Serializable]
    public struct EnemyPair : IPair<Enemy>
    {
        public Enemy Item1 { get => _item1; set => _item1 = value; }
        public Enemy Item2 { get => _item2; set => _item2 = value; }

        [SerializeField]
        private Enemy _item1;
        [SerializeField]
        private Enemy _item2;

        public void Deconstruct(out Enemy item1, out Enemy item2) { item1 = Item1; item2 = Item2; }
    }
}