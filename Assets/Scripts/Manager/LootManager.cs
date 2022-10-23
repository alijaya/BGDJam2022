using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LootManager : MonoBehaviour
{
    public LootItemMB lootSkill;
    public UpgradeMB lootUpgrade;
    public List<InventoryMB> skills;

    public void Start()
    {
        for (var i = 0; i < skills.Count; i++)
        {
            var skill = skills[i];
            skill.UpdateDisplay();
        }

        var item = GlobalRef.instance.currentMapLoot.Value;

        if (item.type == UpgradeOrSkill.UpgradeOrSkillType.Skill)
        {
            lootSkill.cardSkill = item.skill;
            lootSkill.UpdateDisplay();

            lootUpgrade.Hide();
        }
        else if (item.type == UpgradeOrSkill.UpgradeOrSkillType.Upgrade)
        {
            lootUpgrade.upgrade = item.upgrade;
            lootUpgrade.UpdateDisplay();

            lootSkill.GetComponent<SkillMB>().Hide();
        }
    }

    public void LeaveCreate()
    {
        GlobalRef.instance.GoToMap();
    }
}
