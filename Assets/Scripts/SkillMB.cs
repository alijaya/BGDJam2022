using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

[RequireComponent(typeof(CanvasGroup))]
public class SkillMB : MonoBehaviour
{
    public CardSkill cardSkill;

    public TextMeshProUGUI textTitle;
    public TextMeshProUGUI textDescription;

    private bool visible = true;
    private CanvasGroup canvasGroup;
    private int usageInTurn = 0;
    private int usageInBattle = 0;

    private void Awake()
    {
        canvasGroup = GetComponent<CanvasGroup>();
    }

    // Start is called before the first frame update
    void Start()
    {
        ResetUsageInTurn();
        ResetUsageInBattle();
        UpdateDisplay();
    }

    public void ResetUsageInBattle()
    {
        usageInBattle = 0;
    }

    public void ResetUsageInTurn()
    {
        usageInTurn = 0;
    }

    public void UpdateDisplay()
    {
        if (visible)
        {
            canvasGroup.alpha = 1;
            canvasGroup.interactable = true;
            canvasGroup.blocksRaycasts = true;
        }
        else
        {
            canvasGroup.alpha = 0;
            canvasGroup.interactable = false;
            canvasGroup.blocksRaycasts = false;
        }

        textTitle.text = cardSkill.title;
        textDescription.text = cardSkill.description;

        foreach (var slot in GetComponentsInChildren<SlotMB>())
        {
            slot.UpdateDisplay();
        }
    }

    public void Hide()
    {
        visible = false;
        UpdateDisplay();
    }

    public void Show()
    {
        visible = true;
        UpdateDisplay();
    }

    public void ShowHideByUsable()
    {
        if (cardSkill.IsUsable(usageInTurn, usageInBattle))
        {
            Show();
        }
        else
        {
            Hide();
        }
    }

    public bool TryActivate(DiceController dice)
    {
        var diceValue = dice.diceValue;
        var playerStatus = GlobalRef.instance.playerStatus;
        var enemyStatus = GlobalRef.instance.enemyStatus;

        if (cardSkill.DoActionWithTest(diceValue, playerStatus, enemyStatus))
        {
            dice.Hide();

            usageInTurn++;
            usageInBattle++;

            ShowHideByUsable();
            return true;
        }
        else
        {
            return false;
        }
    }
}
