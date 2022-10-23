using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Shop : MonoBehaviour
{
    [SerializeField] private string scene = "Map";


    public List<SkillMB> skills;

    public void Start()
    {
        for (var i = 0; i < skills.Count; i++)
        {
            var skill = skills[i];
            skill.cardSkill = GlobalRef.instance.playerSkills[i];
            skill.UpdateDisplay();
        }
    }

    public void LeaveShop()
    {
        SceneManager.LoadScene(scene);
    }
}
