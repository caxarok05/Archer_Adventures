using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoneyScript : MonoBehaviour
{
    [HideInInspector] public static int Money = 0;

    private static Text _moneyText;

    private void Awake()
    {
        
        _moneyText = GameObject.FindWithTag("MoneyText").GetComponent<Text>();
        Money = PlayerPrefs.GetInt("MoneyKey");
        _moneyText.text = Money.ToString();
    }

    public static void AddMoney()
    {
        Money += ScoreScript.Instance.score;
        PlayerPrefs.SetInt("MoneyKey", Money);
        
    }

    public static void RefreshValue()
    {
        _moneyText.text = Money.ToString();
    }
}



