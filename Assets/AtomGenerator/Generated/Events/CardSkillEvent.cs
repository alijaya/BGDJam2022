using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event of type `CardSkill`. Inherits from `AtomEvent&lt;CardSkill&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-cherry")]
    [CreateAssetMenu(menuName = "Unity Atoms/Events/CardSkill", fileName = "CardSkillEvent")]
    public sealed class CardSkillEvent : AtomEvent<CardSkill>
    {
    }
}
