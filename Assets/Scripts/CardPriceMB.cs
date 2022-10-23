using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CardPriceMB : MonoBehaviour
{
    public CardSkill cardSkill;

    public TextMeshProUGUI text;

    // Start is called before the first frame update
    void Start()
    {
        UpdateDisplay();
    }

    public void UpdateDisplay()
    {
        text.text = "" + cardSkill.price;
    }
}
