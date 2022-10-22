using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DiceController : MonoBehaviour
{
    private RectTransform rt;
    public Sprite[] dice;
    public int dieValue;
    private Vector2 initPosition;

    private void Awake() {
        rt = GetComponent<RectTransform>();
        initPosition = rt.anchoredPosition;
    }

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
        int roll = Random.Range(1, 7);
        Debug.Log(roll);
        gameObject.GetComponent<Image>().sprite = dice[roll-1];
        dieValue = roll;

        // rt.transform.position = initPosition;
        gameObject.GetComponent<DiceController>().enabled = true;
        gameObject.GetComponent<Image>().enabled = true;
    }
}