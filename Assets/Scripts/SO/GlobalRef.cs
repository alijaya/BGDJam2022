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
    public UpgradeOrSkillValueList currentMapShop;
    public UpgradeOrSkillReference currentMapLoot;
    public IntReference currentMapHeal;

    public IntReference playerInitHP;
    public IntReference playerInitMoney;
    public CardSkillValueList playerInitSkills;
    public EnemyValueList enemies;

    public SceneReference sceneMainMenu;
    public SceneReference sceneMap;
    public SceneReference sceneEncounter;
    public SceneReference sceneShop;
    public SceneReference sceneLoot;
    public SceneReference sceneEnding;

    public FloatReference bgmVolume;
    public FloatReference sfxVolume;
    public AudioClip bgmDefault;
    public AudioClip bgmBattle;
    public AudioClip sfxAttack;
    public AudioClip sfxGun;
    public AudioClip sfxHeal;
    public AudioClip sfxLoot;
    public AudioClip sfxShop;
    public AudioClip sfxSip;
    public AudioClip sfxLose;
    public AudioClip sfxWin;
    public AudioClip sfxClick;
    public AudioClip sfxDice;

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
    public void GoToEnding()
    {
        SceneManager.LoadScene(sceneEnding.Name);
    }

    public void ResetData()
    {
        playerStatus.maxHP.Value = playerInitHP.Value;
        playerStatus.FullHP();
        playerMoney.Value = playerInitMoney;
        playerSkills.List = new List<CardSkill>(playerInitSkills.List);
        mapPaths.Clear();
    }

    public void PlayBGMDefault()
    {
        AudioManager.Instance.PlayBGM(bgmDefault);
    }

    public void PlayBGMBattle()
    {
        AudioManager.Instance.PlayBGM(bgmBattle);
    }

    public void PlaySFXAttack()
    {
        AudioManager.Instance.PlaySFX(sfxAttack);
    }
    public void PlaySFXGun()
    {
        AudioManager.Instance.PlaySFX(sfxGun);
    }
    public void PlaySFXHeal()
    {
        AudioManager.Instance.PlaySFX(sfxHeal);
    }
    public void PlaySFXLoot()
    {
        AudioManager.Instance.PlaySFX(sfxLoot);
    }
    public void PlaySFXShop()
    {
        AudioManager.Instance.PlaySFX(sfxShop);
    }
    public void PlaySFXSip()
    {
        AudioManager.Instance.PlaySFX(sfxSip);
    }
    public void PlaySFXLose()
    {
        AudioManager.Instance.PlaySFX(sfxLose);
    }
    public void PlaySFXWin()
    {
        AudioManager.Instance.PlaySFX(sfxWin);
    }
    public void PlaySFXClick()
    {
        AudioManager.Instance.PlaySFX(sfxClick);
    }
    public void PlaySFXDice()
    {
        AudioManager.Instance.PlaySFX(sfxDice);
    }
}
