using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

[RequireComponent(typeof(UpgradeMB))]
public class ShopLootUpgradeMB : MonoBehaviour, IPointerClickHandler
{
    private UpgradeMB upgradeMB;

    public bool isFree = false;

    void Awake()
    {
        upgradeMB = GetComponent<UpgradeMB>();
    }

    void Start()
    {
        upgradeMB.UpdateDisplay();
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        GlobalRef.instance.PlaySFXClick();
        if (isFree)
        {
            upgradeMB.upgrade.DoUpgrade();
            upgradeMB.Hide();
        }
        else
        {
            if (upgradeMB.upgrade.TryBuyUpgrade())
            {
                upgradeMB.Hide();
            }
        }
    }
}
