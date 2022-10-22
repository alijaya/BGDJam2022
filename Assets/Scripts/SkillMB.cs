using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SkillMB : MonoBehaviour
{
    public CardSkill cardSkill;

    public TextMeshProUGUI textTitle;
    public TextMeshProUGUI textDescription;

    // Start is called before the first frame update
    void Start()
    {
        UpdateDisplay();
    }

    public void UpdateDisplay()
    {
        textTitle.text = cardSkill.title;
        textDescription.text = cardSkill.description;
    }
}
