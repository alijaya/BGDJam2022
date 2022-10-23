using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndingManager : MonoBehaviour
{
    public void Start()
    {
        GlobalRef.instance.PlayBGMDefault();
        GlobalRef.instance.PlaySFXWin();
    }

    public void OnMainMenuClick()
    {
        GlobalRef.instance.GoToMainMenu();
    }
}
