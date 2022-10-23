using System;
using UnityEngine;
namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// IPair of type `&lt;CardSkill&gt;`. Inherits from `IPair&lt;CardSkill&gt;`.
    /// </summary>
    [Serializable]
    public struct CardSkillPair : IPair<CardSkill>
    {
        public CardSkill Item1 { get => _item1; set => _item1 = value; }
        public CardSkill Item2 { get => _item2; set => _item2 = value; }

        [SerializeField]
        private CardSkill _item1;
        [SerializeField]
        private CardSkill _item2;

        public void Deconstruct(out CardSkill item1, out CardSkill item2) { item1 = Item1; item2 = Item2; }
    }
}