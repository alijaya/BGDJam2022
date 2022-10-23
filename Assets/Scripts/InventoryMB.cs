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

            var skillToBuy = eventData.pointerDrag.GetComponent<SkillMB>();

            if (TryBuy(skillToBuy))
            {
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
            skillToBuy.Hide();
            GlobalRef.instance.playerSkills[inventoryIndex] = skillToBuy.cardSkill;
            UpdateDisplay();

            return true;
        }
        else
        {
            return false;
        }
    }
}
