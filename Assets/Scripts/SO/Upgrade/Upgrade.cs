using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class Upgrade : ScriptableObject
{
    public enum UpgradeType
    {
        Health,
        MaxHealth,
        Dice
    }

    public string title = "";
    public string description = "";
    public int price = 0;
    public Sprite sprite;
    public UpgradeType type = UpgradeType.Health;
    public int value;

    public virtual void DoUpgrade(UpgradeType type, CharacterStatus player, int value)
    {
        switch (type)
        {
            case UpgradeType.Health: player.DoHealed(value); break;
            case UpgradeType.MaxHealth: player.DoUpgradeMaxHealth(value); break;
            case UpgradeType.Dice: player.DoUpgradeDice(value); break;
        }
    }
}
