using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Slot : MonoBehaviour, IDropHandler {

    public Sprite[] dice;
    private Skill skill;

    private void Awake() {

    }

    public void OnDrop(PointerEventData eventData) {
        if (eventData.pointerDrag != null) {

            GameObject die = eventData.pointerDrag;
            int roll = die.GetComponent<DiceController>().diceValue;
            gameObject.GetComponent<Image>().sprite = dice[roll-1];

            Color temp = gameObject.GetComponent<Image>().color;
            temp = new Color(1f, 1f, 1f, 1f);
            gameObject.GetComponent<Image>().color = temp;

            die.GetComponent<DiceController>().enabled = false;
            die.GetComponent<Image>().enabled = false;

            int currentSkill =  gameObject.transform.parent.GetComponent<SkillController>().currentSkill;
            skill = gameObject.transform.parent.GetComponent<SkillController>().skills[currentSkill];
            Debug.Log(skill.name);
            Debug.Log("Deal "+roll+" dmg");
        }
    }

    public void Reset() {

            gameObject.GetComponent<Image>().sprite = null;

            Color temp = gameObject.GetComponent<Image>().color;
            temp = new Color(.5849f, .5849f, .5849f, .2274f);
            gameObject.GetComponent<Image>().color = temp;
        
    }
}