using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoneyScript : MonoBehaviour
{
    private static int money = 0;
    [SerializeField] private Text moneyText;

    //private void Awake()
    //{
    //    moneyText = gameObject.GetComponent<Text>();
    //}
    private void Update()
    {
        moneyText.text = money.ToString();
    }
    public static void AddMoney()
    {
        money += ScoreScript.Instance.score;
        
    }
}
