using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityAtoms.BaseAtoms;
using System;
using UnityAtoms;

public class BattleManager : MonoBehaviour
{
    public GameObject goInteractive;
    public GameObject goWinningScreen;
    public GameObject goLosingScreen;

    public List<DiceController> dices;
    public List<SkillMB> skills;

    public BoolReference isPlaying;
    public BoolReference isPlayerTurn;
    public BoolReference isWinning;
    public IntReference lootValue;

    public VoidBaseEventReference eventPlayerDeath;
    public VoidBaseEventReference eventEnemyDeath;

    public void Start()
    {
        StartBattle();
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
        // TODO: random for now, but need to replace it with enemy loot
        lootValue.Value = UnityEngine.Random.Range(3, 7);
        isWinning.Value = true;
        isPlaying.Value = false;

        goInteractive.SetActive(false);
        goWinningScreen.SetActive(true);
        goLosingScreen.SetActive(false);
    }

    public void StartBattle()
    {
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
        // for now just do random 1 - 6 damage
        var damage = UnityEngine.Random.Range(1, 7);
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
}
