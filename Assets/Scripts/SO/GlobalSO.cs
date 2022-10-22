using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class GlobalSO<T> : ScriptableObject where T : ScriptableObject
{
    private static T _instance;
    public static T instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = Resources.Load(typeof(T).Name) as T;
            }
            return _instance;
        }
    }
}
