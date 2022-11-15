using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using DG.Tweening;

[RequireComponent(typeof(CanvasGroup), typeof(TextMeshProUGUI))]
public class DamageCounter : MonoBehaviour
{
    public static void SpawnDamage(Vector3 position, int damage)
    {
        var canvas = FindObjectOfType<Canvas>();
        var damageCounter = Instantiate(GlobalRef.instance.prefabDamageCounter, position, Quaternion.identity, canvas.transform);
        damageCounter.SetDamage(damage);
    }

    public static void SpawnHeal(Vector3 position, int damage)
    {
        var canvas = FindObjectOfType<Canvas>();
        var damageCounter = Instantiate(GlobalRef.instance.prefabHealCounter, position, Quaternion.identity, canvas.transform);
        damageCounter.SetDamage(damage);
    }

    private CanvasGroup canvasGroup;
    private TextMeshProUGUI text;
    public float duration = 300; // ms
    public float scale = 1;
    [Range(0, 1)]
    public float fadeStart = 0;
    public Vector2 direction;

    private void Awake()
    {
        text = GetComponent<TextMeshProUGUI>();
        canvasGroup = GetComponent<CanvasGroup>();
    }

    // Start is called before the first frame update
    void Start()
    {
        var durationS = duration / 1000;
        var sequence = DOTween.Sequence();
        sequence.Insert(0, transform.DOMove(transform.position + new Vector3(direction.x, direction.y), durationS));
        sequence.Insert(0, transform.DOScale(scale, durationS));
        sequence.Insert(durationS * fadeStart, canvasGroup.DOFade(0, durationS * (1-fadeStart)));

        sequence.OnComplete(() => Destroy(gameObject));
    }

    public void SetDamage(int damage) {
        text.text = damage.ToString();
    }
}
