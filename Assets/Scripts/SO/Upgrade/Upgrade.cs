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

    public bool TryBuyUpgrade()
    {
        var money = GlobalRef.instance.playerMoney;
        if (money.Value >= price)
        {
            money.Value -= price;
            DoUpgrade();
            return true;
        }
        else
        {
            return false;
        }
    }

    public void DoUpgrade()
    {
        var player = GlobalRef.instance.playerStatus;
        switch (type)
        {
            case UpgradeType.Health: player.DoHealed(value); break;
            case UpgradeType.MaxHealth: player.DoUpgradeMaxHealth(value); break;
            case UpgradeType.Dice: player.DoUpgradeDice(value); break;
        }
    }
}
