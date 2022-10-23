using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragDrop : MonoBehaviour, IBeginDragHandler, IEndDragHandler, IDragHandler {

    private Canvas canvas;

    private RectTransform rectTransform;
    private CanvasGroup canvasGroup;
    private Vector2 initPosition;

    public bool returnToInitPosition = true;
    public float dragAlpha = 0.6f;

    private void Awake() {
        rectTransform = GetComponent<RectTransform>();
        canvasGroup = GetComponent<CanvasGroup>();
        canvas = GetComponentInParent<Canvas>();

        SaveInitPosition();
    }

    public void SaveInitPosition()
    {
        initPosition = rectTransform.anchoredPosition;
    }

    public void OnBeginDrag(PointerEventData eventData) {
        canvasGroup.alpha = dragAlpha;
        canvasGroup.blocksRaycasts = false;
    }

    public void OnDrag(PointerEventData eventData) {
        rectTransform.anchoredPosition += eventData.delta / canvas.scaleFactor;
    }

    public void OnEndDrag(PointerEventData eventData) {
        canvasGroup.alpha = 1f;
        canvasGroup.blocksRaycasts = true;

        if (returnToInitPosition) rectTransform.anchoredPosition = initPosition;
    }
}