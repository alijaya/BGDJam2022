using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Eflatun.SceneReference;
using UnityEngine.SceneManagement;

public class SceneRef : MonoBehaviour
{
    public SceneReference sceneReference;

    public void GoToScene()
    {
        SceneManager.LoadScene(sceneReference.Name);
    }
}
