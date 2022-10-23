using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using TMPro;

public class InventoryMB : MonoBehaviour, IDropHandler
{
    private SkillMB skill;

    public TextMeshProUGUI text;

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
        var cardSkill = skill.cardSkill;
        switch (cardSkill.requirementType)
        {
            case CardSkill.RequirementType.Normal: text.text = ""; break;
            case CardSkill.RequirementType.Exact: text.text = "" + cardSkill.requirementValue; break;
            case CardSkill.RequirementType.Max: text.text = "Max " + cardSkill.requirementValue; break;
            case CardSkill.RequirementType.Min: text.text = "Min " + cardSkill.requirementValue; break;
            case CardSkill.RequirementType.Odd: text.text = "Odd"; break;
            case CardSkill.RequirementType.Even: text.text = "Even"; break;
            default: text.text = ""; break;
        }
    }

    public void OnDrop(PointerEventData eventData)
    {
        if (eventData.pointerDrag != null)
        {

            var item = eventData.pointerDrag.GetComponent<SkillMB>();

            if (skill.TryBuy(item))
            {
                // Ini supaya OnEndDragnya ga kepanggil
                eventData.pointerDrag = null;
            }
            Debug.Log("tumbas");
            Debug.Log(item.cardSkill.title);
            Debug.Log(skill.cardSkill.title);
        }
    }
}
