using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using TMPro;

public class InventoryMB : MonoBehaviour, IDropHandler
{
    public int inventoryIndex = 0;
    private SkillMB skill;

    void Awake()
    {
        skill = GetComponentInParent<SkillMB>();
    }

    void Start()
    {
        UpdateDisplay();
    }

    public void UpdateDisplay()
    {
        skill.cardSkill = GlobalRef.instance.playerSkills[inventoryIndex];
        skill.UpdateDisplay();
    }

    public void OnDrop(PointerEventData eventData)
    {
        if (eventData.pointerDrag != null)
        {

            var skillToGet = eventData.pointerDrag.GetComponent<SkillMB>();
            var shopItem = eventData.pointerDrag.GetComponent<ShopItemMB>();
            var lootItem = eventData.pointerDrag.GetComponent<LootItemMB>();

            if (shopItem) // untuk ngecek ini barang jualan atau loot, not elegant solution tho ==a
            {
                if (TryBuy(skillToGet))
                {
                    // Ini supaya OnEndDragnya ga kepanggil
                    eventData.pointerDrag = null;
                }
            }
            if (lootItem)
            {
                GetSkill(skillToGet);

                // Ini supaya OnEndDragnya ga kepanggil
                eventData.pointerDrag = null;
            }
        }
    }

    public bool TryBuy(SkillMB skillToBuy)
    {
        var playerMoney = GlobalRef.instance.playerMoney;
        if (playerMoney.Value >= skillToBuy.cardSkill.price)
        {
            playerMoney.Value -= skillToBuy.cardSkill.price;
            GetSkill(skillToBuy);

            return true;
        }
        else
        {
            return false;
        }
    }

    public void GetSkill(SkillMB skillToGet)
    {
        skillToGet.Hide();
        GlobalRef.instance.playerSkills[inventoryIndex] = skillToGet.cardSkill;
        UpdateDisplay();
    }
}
