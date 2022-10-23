using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityAtoms.BaseAtoms;

public class BoolActiveGO : MonoBehaviour
{
    public BoolReference value;
    private BoolEvent valueChanged;

    public bool invert = false;

    void Awake()
    {
        valueChanged = value.GetEvent<BoolEvent>();
        valueChanged.Register(UpdateDisplay);
        UpdateDisplay();
    }

    public void UpdateDisplay()
    {
        gameObject.SetActive(invert ^ value.Value);
    }
}
