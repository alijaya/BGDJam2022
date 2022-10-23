using System;
using UnityEngine;
namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// IPair of type `&lt;UpgradeOrSkill&gt;`. Inherits from `IPair&lt;UpgradeOrSkill&gt;`.
    /// </summary>
    [Serializable]
    public struct UpgradeOrSkillPair : IPair<UpgradeOrSkill>
    {
        public UpgradeOrSkill Item1 { get => _item1; set => _item1 = value; }
        public UpgradeOrSkill Item2 { get => _item2; set => _item2 = value; }

        [SerializeField]
        private UpgradeOrSkill _item1;
        [SerializeField]
        private UpgradeOrSkill _item2;

        public void Deconstruct(out UpgradeOrSkill item1, out UpgradeOrSkill item2) { item1 = Item1; item2 = Item2; }
    }
}