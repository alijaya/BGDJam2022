using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ShopManager : MonoBehaviour
{
    [SerializeField] private string scene = "Map";

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

        var items = new List<CardSkill>(GlobalRef.instance.shopItems);
        items.Shuffle();
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

    // public void RandomizeShop()
    // {
    //     Debug.Log("test");

    //     for (var i = 0; i < skills.Count; i++)
    //     {
    //         var skill = skills[i];
    //         skill.cardSkill = GlobalRef.instance.playerSkills[i];
    //         skill.UpdateDisplay();
    //     }

    //     for (var i = 0; i < 3; i++)
    //     {
    //         var shopItems = skills[i];
    //         skill.cardSkill = GlobalRef.instance.playerSkills[i];
    //         skill.UpdateDisplay();
    //     }
    // }

    public void LeaveShop()
    {
        SceneManager.LoadScene(scene);
    }
}
