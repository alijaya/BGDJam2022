using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class Enemy : ScriptableObject, System.IEquatable<Enemy>
{
    public Sprite sprite;
    public string title;
    public int maxHP;
    public int lootValue;
    public int minDamage;
    public int maxDamage;

    public bool Equals(Enemy other)
    {
        return this == other;
    }
}
