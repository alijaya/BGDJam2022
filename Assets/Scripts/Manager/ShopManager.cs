using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ShopManager : MonoBehaviour
{
    public List<InventoryMB> skills;
    public List<ShopItemMB> skillItems;
    public List<UpgradeMB> upgradeItems;
    public List<CardPriceMB> cardPrices;

    public void Start()
    {
        // RandomizeShop();

        for (var i = 0; i < skills.Count; i++)
        {
            var skill = skills[i];
            skill.UpdateDisplay();
        }

        //var items = GlobalRef.instance.currentMapShop;
        //for (var i = 0; i < shopItems.Count; i++)
        //{
        //    var shop = shopItems[i];
        //    var cardPrice = cardPrices[i];
        //    shop.cardSkill = items[i];
        //    shop.UpdateDisplay();

        //    cardPrice.cardSkill = shop.cardSkill;
        //    cardPrice.UpdateDisplay();
        //}
        var items = GlobalRef.instance.currentMapShop;
        for (var i = 0; i < skillItems.Count; i++)
        {
            var skill = skillItems[i];
            var upgrade = upgradeItems[i];
            var cardPrice = cardPrices[i];

            var item = items[i];

            cardPrice.item = item;
            cardPrice.UpdateDisplay();

            if (item.type == UpgradeOrSkill.UpgradeOrSkillType.Skill)
            {
                skill.cardSkill = item.skill;
                skill.UpdateDisplay();

                upgrade.Hide();
            } else if (item.type == UpgradeOrSkill.UpgradeOrSkillType.Upgrade)
            {
                upgrade.upgrade = item.upgrade;
                upgrade.UpdateDisplay();

                skill.GetComponent<SkillMB>().Hide();
            }
        }
    }

    public void LeaveShop()
    {
        GlobalRef.instance.GoToMap();
    }
}
