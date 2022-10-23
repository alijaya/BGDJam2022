using UnityEngine;
using UnityAtoms.BaseAtoms;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Adds Variable Instancer's Variable of type UpgradeOrSkill to a Collection or List on OnEnable and removes it on OnDestroy. 
    /// </summary>
    [AddComponentMenu("Unity Atoms/Sync Variable Instancer to Collection/Sync UpgradeOrSkill Variable Instancer to Collection")]
    [EditorIcon("atom-icon-delicate")]
    public class SyncUpgradeOrSkillVariableInstancerToCollection : SyncVariableInstancerToCollection<UpgradeOrSkill, UpgradeOrSkillVariable, UpgradeOrSkillVariableInstancer> { }
}
