using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

[RequireComponent(typeof(CanvasGroup))]
public class UpgradeMB : MonoBehaviour
{
    public Upgrade upgrade;

    public TextMeshProUGUI textTitle;
    public TextMeshProUGUI textDescription;
    public Image image;

    private bool visible = true;
    private CanvasGroup canvasGroup;

    private void Awake()
    {
        canvasGroup = GetComponent<CanvasGroup>();
    }

    void Start()
    {
        UpdateDisplay();
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

        if (upgrade)
        {
            textTitle.text = upgrade.title;
            textDescription.text = upgrade.description;
            image.sprite = upgrade.sprite;
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
}
