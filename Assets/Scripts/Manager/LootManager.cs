using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LootManager : MonoBehaviour
{
    public LootItemMB lootItem;
    public List<InventoryMB> skills;

    public void Start()
    {
        for (var i = 0; i < skills.Count; i++)
        {
            var skill = skills[i];
            skill.UpdateDisplay();
        }

        var item = GlobalRef.instance.currentMapLoot;
        lootItem.cardSkill = item;
    }

    public void LeaveCreate()
    {
        GlobalRef.instance.GoToMap();
    }
}
