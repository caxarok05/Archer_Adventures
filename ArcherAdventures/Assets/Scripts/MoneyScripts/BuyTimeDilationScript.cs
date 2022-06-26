using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuyTimeDilationScript : MonoBehaviour
{
    [Header("Time Dilation price")]

    [SerializeField] private int _upgradeNumber;
    [SerializeField] private List<string> _upgradePrices = new List<string>();

    [Header("Time Dilation UI")]

    [SerializeField] private Button _upgradeButton;
    [SerializeField] private Text _upgradeText;
    public static int _currentUpgrade = 0;

    private void Awake()
    {
        _currentUpgrade = PlayerPrefs.GetInt("TimeDilationKey");
        _upgradeText.text = _upgradePrices[_currentUpgrade].ToString();
        if (_currentUpgrade >= _upgradeNumber)
        {
            _upgradeButton.interactable = false;
            _upgradeText.text = _upgradePrices[_upgradePrices.Count - 1].ToString();
        }
    }
    private void Update()
    {
        if (_currentUpgrade >= _upgradeNumber || MoneyScript.Money - int.Parse(_upgradePrices[_currentUpgrade]) < 0)
        {
            _upgradeButton.interactable = false;
        }
    }

    public void BuyTimeDilationUpgrade()
    {
        MoneyScript.Money -= int.Parse(_upgradePrices[_currentUpgrade]);
        MoneyScript.RefreshValue();
        _currentUpgrade++;
        Debug.Log(_currentUpgrade);
        _upgradeText.text = _upgradePrices[_currentUpgrade].ToString();


        if (_currentUpgrade >= _upgradeNumber)
        {
            _upgradeButton.interactable = false;
            _upgradeText.text = _upgradePrices[_upgradePrices.Count - 1].ToString();
        }
        PlayerPrefs.SetInt("TimeDilationKey", _currentUpgrade);

    }
}
 