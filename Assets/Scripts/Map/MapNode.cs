using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityAtoms.BaseAtoms;
using UnityEngine.UI;
using System.Linq;

public class MapNode : MonoBehaviour
{
    public enum NodeType
    {
        Encounter,
        Shop,
        Loot,
        Heal,
    }

    public enum NodeState
    {
        Unreachable,
        Reachable,
        Done
    }

    public NodeType nodeType;

    public EnemyValueList possibleEncounterEnemies;

    public UpgradeOrSkillValueList possibleShopCards;

    public UpgradeOrSkillValueList possibleLootCards;

    public int possibleHealMin = 0;
    public int possibleHealMax = 0;

    public List<MapNode> nextNode;

    public NodeState nodeState = NodeState.Unreachable;

    public List<Sprite> baseSprites;
    public List<Sprite> doneSprites;

    private Image image;
    private Button button;
    private MapManager mapManager;

    private void Awake()
    {
        image = GetComponent<Image>();
        button = GetComponent<Button>();
        mapManager = FindObjectOfType<MapManager>();
    }

    private void Start()
    {
        UpdateDisplay();
    }

    public void UpdateDisplay()
    {
        switch (nodeState)
        {
            case NodeState.Unreachable:
                image.sprite = baseSprites[(int)nodeType];
                image.color = new Color(.75f, .75f, .75f);
                button.interactable = false;
                break;

            case NodeState.Reachable:
                image.sprite = baseSprites[(int)nodeType];
                image.color = new Color(0,0,0);
                button.interactable = true;
                break;

            case NodeState.Done:
                image.sprite = doneSprites[(int)nodeType];
                image.color = new Color(0,0,0);
                button.interactable = false;
                break;
        }
    }

    public void ExecuteNode()
    {
        GlobalRef.instance.mapPaths.Add(name);
        switch (nodeType)
        {
            case NodeType.Encounter:
                GlobalRef.instance.currentMapEncounter.Value = possibleEncounterEnemies[Random.Range(0, possibleEncounterEnemies.Count)];
                GlobalRef.instance.GoToEncounter();
                break;
            case NodeType.Shop:
                var cards = new List<UpgradeOrSkill>(possibleShopCards);
                cards.Shuffle();
                GlobalRef.instance.currentMapShop.List = cards.Take(3).ToList();
                GlobalRef.instance.GoToShop();
                break;
            case NodeType.Loot:
                GlobalRef.instance.currentMapLoot.Value = possibleLootCards[Random.Range(0, possibleLootCards.Count)];
                GlobalRef.instance.GoToLoot();
                break;
            case NodeType.Heal:
                var heal = Random.Range(possibleHealMin, possibleHealMax + 1);
                GlobalRef.instance.currentMapHeal.Value = heal;
                GlobalRef.instance.playerStatus.currentHP.Value += heal;
                mapManager.UpdateDisplay();
                break;
        }
    }
}
