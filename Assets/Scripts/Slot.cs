using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Slot : MonoBehaviour, IDropHandler {

    private void Awake() {
        Debug.Log("tre");
        Debug.Log(GetComponent<RectTransform>().anchoredPosition);
        Debug.Log(GetComponentInParent<RectTransform>().anchoredPosition);
    }

    public void OnDrop(PointerEventData eventData) {
        Debug.Log("OnDrop");
        if (eventData.pointerDrag != null) {
            eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;
        }
    }
}