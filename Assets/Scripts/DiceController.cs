using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DiceController : MonoBehaviour
{
    private RectTransform rt;
    public Sprite[] dice;
    public int diceValue;

    private CanvasGroup canvasGroup;
    private Vector2 initPosition;
    private bool visible = true;

    private void Awake() {
        rt = GetComponent<RectTransform>();
        canvasGroup = GetComponent<CanvasGroup>();
        initPosition = rt.anchoredPosition;
    }

    // Start is called before the first frame update
    void Start()
    {
        RollDice();

    }

    public void RollDice()
    {
        visible = true;
        diceValue = Random.Range(1, 7);

        ResetPosition();
        UpdateDisplay();
    }

    public void ResetPosition()
    {
        rt.anchoredPosition = initPosition;
    }

    public void UpdateDisplay()
    {
        gameObject.GetComponent<Image>().sprite = dice[diceValue - 1];

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