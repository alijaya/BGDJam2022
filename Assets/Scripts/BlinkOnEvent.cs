using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityAtoms.BaseAtoms;
using DG.Tweening;

[RequireComponent(typeof(CanvasGroup))]
public class BlinkOnEvent : MonoBehaviour
{
    public IntEventReference eventReference;
    public float duration = 50; // ms

    private CanvasGroup canvasGroup;

    private void Awake()
    {
        canvasGroup = GetComponent<CanvasGroup>();
    }

    private void OnEnable()
    {
        eventReference.Event.Register(Blink);
    }

    private void OnDisable()
    {
        eventReference.Event.Unregister(Blink);
    }

    public void Blink()
    {
        canvasGroup.DOFade(0.5f, duration / 1000).SetEase(Ease.Flash, 2);
    }
}
