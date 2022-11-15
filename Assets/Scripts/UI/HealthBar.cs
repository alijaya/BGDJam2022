using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityAtoms.BaseAtoms;

public class HealthBar : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI text;
    [SerializeField] private RectTransform fillBar;
    [SerializeField] private Transform damageSpawner;

    public CharacterStatus characterStatus;

    private IntReference currentHealth;
    private IntReference maxHealth;

    private IntEvent currentHealthChanged;
    private IntEvent maxHealthChanged;
    private IntEvent damagedEvent;
    private IntEvent healedEvent;
    void Awake()
    {
        currentHealth = characterStatus.currentHP;
        maxHealth = characterStatus.maxHP;
        currentHealthChanged = currentHealth.GetEvent<IntEvent>();
        maxHealthChanged = maxHealth.GetEvent<IntEvent>();
        damagedEvent = characterStatus.damagedEvent;
        healedEvent = characterStatus.healedEvent;
    }

    private void OnEnable()
    {
        currentHealthChanged.Register(UpdateDisplay);
        maxHealthChanged.Register(UpdateDisplay);
        damagedEvent.Register(ShowDamageCounter);
        healedEvent.Register(ShowHealCounter);
        UpdateDisplay();
    }

    private void OnDisable()
    {
        currentHealthChanged.Unregister(UpdateDisplay);
        maxHealthChanged.Unregister(UpdateDisplay);
        damagedEvent.Unregister(ShowDamageCounter);
        healedEvent.Unregister(ShowHealCounter);
    }

    public void ShowDamageCounter(int value)
    {
        DamageCounter.SpawnDamage(damageSpawner.position, value);
    }

    public void ShowHealCounter(int value)
    {
        DamageCounter.SpawnHeal(damageSpawner.position, value);
    }

    public void UpdateDisplay()
    {
        text.text = currentHealth.Value + " / " + maxHealth.Value;
        var percentage = (float)currentHealth.Value / maxHealth.Value;
        fillBar.anchorMax = new Vector2(percentage, fillBar.anchorMax.y);
        fillBar.anchorMin = new Vector2(percentage - 1, fillBar.anchorMin.y);
    }


}
