using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndingManager : MonoBehaviour
{
    public void OnMainMenuClick()
    {
        GlobalRef.instance.GoToMainMenu();
    }
}
