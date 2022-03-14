using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AddingHearts : MonoBehaviour
{
    [SerializeField] private int _upgradeNumber;
    [SerializeField] private List<string> _upgradePrices = new List<string>();
    [SerializeField] private Button _upgradeButton;
    [SerializeField] private Text _upgradeText;
    private static int _currentUpgrade = 0;
    public static int Event_counter = 3;

    private void Awake()
    {
        _currentUpgrade = PlayerPrefs.GetInt("HPCountKey");
        _upgradeText.text = _upgradePrices[_currentUpgrade].ToString();
    }
    private void Update()
    {
        if (_currentUpgrade >= _upgradeNumber || MoneyScript.Money - int.Parse(_upgradePrices[_currentUpgrade]) < 0)
        {
            _upgradeButton.interactable = false;
        }
    }
    public void Adding_Hp()
    {
        MoneyScript.Money -= int.Parse(_upgradePrices[_currentUpgrade]);
        MoneyScript.RefreshValue();
        Event_counter++;    
        _currentUpgrade++;      
        _upgradeText.text = _upgradePrices[_currentUpgrade].ToString();

        if (_currentUpgrade >= _upgradeNumber)
        {
            _upgradeButton.interactable = false;
            _upgradeText.text = _upgradePrices[_upgradePrices.Count - 1].ToString();
        }
        PlayerPrefs.SetInt("HPCountKey", _currentUpgrade);
    }
  
}
