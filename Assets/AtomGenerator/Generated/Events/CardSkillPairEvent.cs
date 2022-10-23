using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event of type `CardSkillPair`. Inherits from `AtomEvent&lt;CardSkillPair&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-cherry")]
    [CreateAssetMenu(menuName = "Unity Atoms/Events/CardSkillPair", fileName = "CardSkillPairEvent")]
    public sealed class CardSkillPairEvent : AtomEvent<CardSkillPair>
    {
    }
}
