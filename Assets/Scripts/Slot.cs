using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Slot : MonoBehaviour, IDropHandler {

    public Sprite[] dice;

    private void Awake() {
        Debug.Log("tre");
        Debug.Log(GetComponent<RectTransform>().anchoredPosition);
        Debug.Log(GetComponentInParent<RectTransform>().anchoredPosition);
    }

    public void OnDrop(PointerEventData eventData) {
        Debug.Log("OnDrop");
        if (eventData.pointerDrag != null) {
            // eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().position;
            GameObject die = eventData.pointerDrag;
            int roll = die.GetComponent<DiceController>().dieValue;
            gameObject.GetComponent<Image>().sprite = dice[roll-1];
            Color temp = gameObject.GetComponent<Image>().color;
            temp = new Color(1f, 1f, 1f, 1f);
            // temp = new Color(.5849f, .5849f, .5849f, .2274f);
            gameObject.GetComponent<Image>().color = temp;
            die.GetComponent<DiceController>().enabled = false;
            die.GetComponent<Image>().enabled = false;
        }
    }

    public void Reset() {
            gameObject.GetComponent<Image>().sprite = null;
            Color temp = gameObject.GetComponent<Image>().color;
            temp = new Color(.5849f, .5849f, .5849f, .2274f);
            gameObject.GetComponent<Image>().color = temp;
        
    }
}