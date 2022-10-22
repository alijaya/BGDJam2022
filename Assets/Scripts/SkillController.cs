using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkillController : MonoBehaviour
{
    public List<Skill> skills;
    public int currentSkill;

    void Awake(){

        skills = new List<Skill>();     

        skills.Add(
            new Skill { 
                idx = 1, 
                name = "Cane",
                skillDescription = "Whack with cane.\nN damage.",
                modOperation = "+",
                modValue = 0,
                reqType = 1, 
                reqValue = 0,
                reqDescription = "",
                isHeal = false,
                isReroll = false,
                isFixedDamage = false
            }
        );
        skills.Add(
            new Skill { 
                idx = 2, 
                name = "Cane2",
                skillDescription = "Whack with cane2.\nN damage.",
                modOperation = "+",
                modValue = 0,
                reqType = 1, 
                reqValue = 0,
                reqDescription = "",
                isHeal = false,
                isReroll = false,
                isFixedDamage = false
            }
        );
        skills.Add(
            new Skill { 
                idx = 3, 
                name = "Cane3",
                skillDescription = "Whack with cane3.\nN damage.",
                modOperation = "+",
                modValue = 0,
                reqType = 1, 
                reqValue = 0,
                reqDescription = "",
                isHeal = false,
                isReroll = false,
                isFixedDamage = false
            }
        );
        Debug.Log(skills);
    }

    // Start is called before the first frame update
    void Start()
    {
        // currentSkill = 0;
        gameObject.transform.Find("SkillName").GetComponent<TMPro.TextMeshProUGUI>().text = skills[currentSkill].name; 
        gameObject.transform.Find("SkillReq").GetComponent<TMPro.TextMeshProUGUI>().text = skills[currentSkill].reqDescription; 
        gameObject.transform.Find("SkillDesc").GetComponent<TMPro.TextMeshProUGUI>().text = skills[currentSkill].skillDescription; 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
