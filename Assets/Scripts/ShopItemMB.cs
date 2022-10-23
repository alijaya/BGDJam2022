using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using TMPro;

public class ShopItemMB : MonoBehaviour
{
    private SkillMB skill;
    public CardSkill cardSkill;

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
        if (cardSkill)
        {
            skill.cardSkill = cardSkill;
            skill.UpdateDisplay();
        }
    }

}
