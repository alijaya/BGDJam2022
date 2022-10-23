using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using TMPro;

public class SlotMB : MonoBehaviour, IDropHandler
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

            var dice = eventData.pointerDrag.GetComponent<DiceController>();

            if (skill.TryActivate(dice))
            {
                // Ini supaya OnEndDragnya ga kepanggil
                eventData.pointerDrag = null;
            }
        }
    }
}
