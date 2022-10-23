using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ShopManager : MonoBehaviour
{
    public List<InventoryMB> skills;
    public List<ShopItemMB> shopItems;
    public List<CardPriceMB> cardPrices;

    public void Start()
    {
        // RandomizeShop();

        for (var i = 0; i < skills.Count; i++)
        {
            var skill = skills[i];
            skill.UpdateDisplay();
        }

        var items = GlobalRef.instance.currentMapShop;
        for (var i = 0; i < shopItems.Count; i++)
        {
            var shop = shopItems[i];
            var cardPrice = cardPrices[i];
            shop.cardSkill = items[i];
            shop.UpdateDisplay();

            cardPrice.cardSkill = shop.cardSkill;
            cardPrice.UpdateDisplay();
        }
    }

    public void LeaveShop()
    {
        GlobalRef.instance.GoToMap();
    }
}
