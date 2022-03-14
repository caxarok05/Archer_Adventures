using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuyUpgradesScript : MonoBehaviour
{
    [SerializeField] private int _upgradeNumber;
    [SerializeField] private List<int> _upgradePrices = new List<int>();
    [SerializeField] private Button _upgradeButton;
    [SerializeField] private Text _upgradeText;
    private int _currentUpgrade = 0;

    private void Awake()
    {
        if (_upgradeButton.interactable == true && MoneyScript.Money >= _upgradePrices[_currentUpgrade])
        {
            _upgradeButton.interactable = true;
        }
    }

    private void BuyUpgrade()
    {
        if (_upgradeButton.interactable == true && MoneyScript.Money >= _upgradePrices[_currentUpgrade])
        {
            
        }
    }

}
