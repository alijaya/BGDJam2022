using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LootItemMB : MonoBehaviour
{
    private SkillMB skill;
    public CardSkill cardSkill;

    void Awake()
    {
        skill = GetComponent<SkillMB>();
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
