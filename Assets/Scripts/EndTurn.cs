using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTurn : MonoBehaviour
{
    public GameObject[] dice, slots;
    public GameObject die, slot;

    public void RerollDie()
    {
        dice = GameObject.FindGameObjectsWithTag("Dice");
        foreach (GameObject die in dice) {
            die.GetComponent<DiceController>().RollDice();
        }

        slots = GameObject.FindGameObjectsWithTag("Slot");
        foreach (GameObject slot in slots) {
            slot.GetComponent<Slot>().Reset();
        }
    }
}
