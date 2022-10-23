using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GlobalRef.instance.PlayDefaultBGM();
        GlobalRef.instance.ResetData();
    }

    public void OnStartGame()
    {
        GlobalRef.instance.GoToMap();
    }
}
