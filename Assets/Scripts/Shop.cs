using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Shop : MonoBehaviour
{
    [SerializeField] private string scene = "Map";

    public void LeaveShop()
    {
        SceneManager.LoadScene(scene);
    }
}
