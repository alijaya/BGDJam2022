using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Shop : MonoBehaviour
{
    [SerializeField] private string scene = "Map";

    public List<InventoryMB> skills;
    public List<ShopItemMB> shopItems;

    public void Start()
    {
        // RandomizeShop();

        for (var i = 0; i < skills.Count; i++)
        {
            var skill = skills[i];
            skill.UpdateDisplay();
        }

        for (var i = 0; i < shopItems.Count; i++)
        {
            var shop = shopItems[i];
            shop.cardSkill = GlobalRef.instance.shopItems[Random.Range(0, GlobalRef.instance.shopItems.Count)];
            shop.UpdateDisplay();
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
