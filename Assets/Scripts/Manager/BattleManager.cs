using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityAtoms.BaseAtoms;
using System;
using UnityAtoms;
using UnityEngine.UI;

public class BattleManager : MonoBehaviour
{
    public Enemy enemy;

    public GameObject goInteractive;
    public GameObject goWinningScreen;
    public GameObject goLosingScreen;

    public List<DiceController> dices;
    public List<SkillMB> skills;
    public Image enemyImage;

    public BoolReference isPlaying;
    public BoolReference isPlayerTurn;
    public BoolReference isWinning;
    public IntReference lootValue;

    public VoidBaseEventReference eventPlayerDeath;
    public VoidBaseEventReference eventEnemyDeath;

    public void Start()
    {
        GlobalRef.instance.PlayBattleBGM();
        StartWithMapEncounter();
    }

    public void StartWithMapEncounter()
    {
        enemy = GlobalRef.instance.currentMapEncounter;
        StartBattle();
    }

    public void StartRandom()
    {
        SelectRandomEnemy();
        StartBattle();
    }

    public void StartBattleFullHP()
    {
        GlobalRef.instance.playerStatus.FullHP();
        StartBattle();
    }

    public void StartRandomFullHP()
    {
        GlobalRef.instance.playerStatus.FullHP();
        StartRandom();
    }

    public void OnEnable()
    {
        eventPlayerDeath.Event.Register(OnPlayerDeath);
        eventEnemyDeath.Event.Register(OnEnemyDeath);
    }

    public void OnDisable()
    {
        eventPlayerDeath.Event.Unregister(OnPlayerDeath);
        eventEnemyDeath.Event.Unregister(OnEnemyDeath);
    }

    private void OnPlayerDeath()
    {
        isWinning.Value = false;
        isPlaying.Value = false;

        goInteractive.SetActive(false);
        goWinningScreen.SetActive(false);
        goLosingScreen.SetActive(true);
    }

    private void OnEnemyDeath()
    {
        lootValue.Value = enemy.lootValue;
        isWinning.Value = true;
        isPlaying.Value = false;

        goInteractive.SetActive(false);
        goWinningScreen.SetActive(true);
        goLosingScreen.SetActive(false);
    }

    public void SelectRandomEnemy()
    {
        var enemies = GlobalRef.instance.enemies;
        enemy = enemies[UnityEngine.Random.Range(0, enemies.Count)];
    }

    public void PrepareEnemy()
    {
        var enemyStatus = GlobalRef.instance.enemyStatus;
        enemyStatus.title.Value = enemy.title;
        enemyStatus.maxHP.Value = enemy.maxHP;
        enemyStatus.FullHP();
        enemyImage.sprite = enemy.sprite;
        enemyImage.SetNativeSize();
    }

    public void StartBattle()
    {
        PrepareEnemy();
        isPlaying.Value = true;

        goInteractive.SetActive(true);
        goWinningScreen.SetActive(false);
        goLosingScreen.SetActive(false);

        for (var i = 0; i < skills.Count; i++)
        {
            var skill = skills[i];
            skill.cardSkill = GlobalRef.instance.playerSkills[i];
            skill.ResetUsageInBattle();
            skill.ResetUsageInTurn();
            skill.UpdateDisplay();
        }
        SetTurn(true);
    }

    public void StartTurn()
    {
        RerollDice();
        RefreshSkill();
    }

    public void ChangeTurn()
    {
        SetTurn(!isPlayerTurn);
    }

    public void EnemyTurn()
    {
        // enemy logic here
        // for now just do random min - max damage
        var damage = UnityEngine.Random.Range(enemy.minDamage, enemy.maxDamage + 1);
        GlobalRef.instance.playerStatus.DoDamaged(damage);

        ChangeTurn();
    }

    public void SetTurn(bool isPlayerTurn)
    {
        this.isPlayerTurn.Value = isPlayerTurn;
        if (isPlayerTurn)
        {
            StartTurn();
        }
        else
        {
            EnemyTurn();
        }
    }

    public void RerollDice()
    {
        foreach (var dice in dices)
        {
            dice.RollDice();
        }
    }

    public void RefreshSkill()
    {
        foreach (var skill in skills)
        {
            skill.ResetUsageInTurn();
            skill.ShowHideByUsable();
        }
    }

    public void OnClickLoseQuit()
    {
        GlobalRef.instance.GoToMainMenu();
    }

    public void OnClickWin()
    {
        GlobalRef.instance.playerMoney.Value += lootValue.Value;
        GlobalRef.instance.GoToMap();
    }
}
