using UnityEngine;
using System;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Variable of type `CardSkill`. Inherits from `AtomVariable&lt;CardSkill, CardSkillPair, CardSkillEvent, CardSkillPairEvent, CardSkillCardSkillFunction&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-lush")]
    [CreateAssetMenu(menuName = "Unity Atoms/Variables/CardSkill", fileName = "CardSkillVariable")]
    public sealed class CardSkillVariable : AtomVariable<CardSkill, CardSkillPair, CardSkillEvent, CardSkillPairEvent, CardSkillCardSkillFunction>
    {
        protected override bool ValueEquals(CardSkill other)
        {
            throw new NotImplementedException();
        }
    }
}
