using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityAtoms.BaseAtoms;

public class HealthBar : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI text;
    [SerializeField] private RectTransform fillBar;

    public IntReference currentHealth;
    public IntReference maxHealth;

    private IntEvent currentHealthChanged;
    private IntEvent maxHealthChanged;
    void Awake()
    {
        currentHealthChanged = currentHealth.GetEvent<IntEvent>();
        maxHealthChanged = maxHealth.GetEvent<IntEvent>();
    }

    private void OnEnable()
    {
        currentHealthChanged.Register(UpdateDisplay);
        maxHealthChanged.Register(UpdateDisplay);
        UpdateDisplay();
    }

    private void OnDisable()
    {
        currentHealthChanged.Unregister(UpdateDisplay);
        maxHealthChanged.Unregister(UpdateDisplay);
    }

    public void UpdateDisplay()
    {
        text.text = currentHealth.Value + " / " + maxHealth.Value;
        var percentage = (float)currentHealth.Value / maxHealth.Value;
        Debug.Log(percentage);
        fillBar.anchorMax = new Vector2(percentage, fillBar.anchorMax.y);
        fillBar.anchorMin = new Vector2(percentage - 1, fillBar.anchorMin.y);
    }


}
