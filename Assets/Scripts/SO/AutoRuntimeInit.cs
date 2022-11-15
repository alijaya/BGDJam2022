using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class AutoRuntimeInit : GlobalSO<AutoRuntimeInit>
{
    public List<GameObject> globalPrefabs;

    [RuntimeInitializeOnLoadMethod]
    static void OnBeforeSceneLoadRuntime()
    {
        var autoRuntimeInit = instance;
        foreach (var prefab in instance.globalPrefabs)
        {
            var go = Instantiate(prefab);
            DontDestroyOnLoad(go);
        }
    }
}
