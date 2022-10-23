using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityAtoms.BaseAtoms;
using Eflatun.SceneReference;
using UnityEngine.SceneManagement;

[CreateAssetMenu]
public class GlobalRef : GlobalSO<GlobalRef>
{
    public CharacterStatus playerStatus;
    public CharacterStatus enemyStatus;
    public IntReference playerMoney;
    public CardSkillValueList playerSkills;

    public StringValueList mapPaths;
    public EnemyReference currentMapEncounter;
    public CardSkillValueList currentMapShop;
    public CardSkillReference currentMapLoot;
    public IntReference currentMapHeal;

    public IntReference playerInitHP;
    public IntReference playerInitMoney;
    public CardSkillValueList playerInitSkills;
    public EnemyValueList enemies;
    public CardSkillValueList shopItems;

    public SceneReference sceneMainMenu;
    public SceneReference sceneMap;
    public SceneReference sceneEncounter;
    public SceneReference sceneShop;
    public SceneReference sceneLoot;

    public void GoToMainMenu()
    {
        SceneManager.LoadScene(sceneMainMenu.Name);
    }
    public void GoToMap()
    {
        SceneManager.LoadScene(sceneMap.Name);
    }
    public void GoToEncounter()
    {
        SceneManager.LoadScene(sceneEncounter.Name);
    }
    public void GoToShop()
    {
        SceneManager.LoadScene(sceneShop.Name);
    }
    public void GoToLoot()
    {
        SceneManager.LoadScene(sceneLoot.Name);
    }

    public void ResetData()
    {
        playerStatus.maxHP.Value = playerInitHP.Value;
        playerStatus.FullHP();
        playerMoney.Value = playerInitMoney;
        playerSkills.List = new List<CardSkill>(playerInitSkills.List);
        mapPaths.Clear();
    }
}
