using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class SlotMB : MonoBehaviour, IDropHandler
{
    private SkillMB skill;
    private CardSkill cardSkill;

    void Awake()
    {
        skill = GetComponentInParent<SkillMB>();
        cardSkill = skill.cardSkill;
    }

    public void OnDrop(PointerEventData eventData)
    {
        if (eventData.pointerDrag != null)
        {

            GameObject die = eventData.pointerDrag;
            var roll = die.GetComponent<DiceController>().dieValue;

            var playerStatus = GlobalRef.instance.playerStatus;
            var enemyStatus = GlobalRef.instance.enemyStatus;
            cardSkill.DoActionWithTest(roll, playerStatus, enemyStatus);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
