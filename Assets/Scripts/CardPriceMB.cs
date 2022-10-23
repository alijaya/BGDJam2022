using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CardPriceMB : MonoBehaviour
{
    public UpgradeOrSkill item;

    public TextMeshProUGUI text;

    // Start is called before the first frame update
    void Start()
    {
        UpdateDisplay();
    }

    public void UpdateDisplay()
    {
        if (item.type == UpgradeOrSkill.UpgradeOrSkillType.Upgrade)
        {
            text.text = "" + item.upgrade?.price;
        } else if (item.type == UpgradeOrSkill.UpgradeOrSkillType.Skill)
        {
            text.text = "" + item.skill?.price;
        }
    }
}
