using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTurn : MonoBehaviour
{
    public GameObject[] dice;
    public GameObject die;

    public void RerollDie()
    {
        dice = GameObject.FindGameObjectsWithTag("Dice");
        foreach (GameObject die in dice) {
            die.GetComponent<DiceController>().RollDie();
        }
    }
}
