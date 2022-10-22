using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DiceController : MonoBehaviour
{
    RectTransform rt;
    public Sprite[] dice;
    [SerializeField] public int dieValue;

    // Start is called before the first frame update
    void Start()
    {
        RollDie();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void RollDie() {
        int roll = Random.Range(1, 6);
        Debug.Log(roll);
        gameObject.GetComponent<Image>().sprite = dice[roll-1];
        dieValue = roll;
    }
}
