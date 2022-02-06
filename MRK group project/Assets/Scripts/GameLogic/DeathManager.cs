using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class DeathManager : MonoBehaviour
{
    [SerializeField] protected int _heart_numbers = 3;
    [SerializeField] protected List<GameObject> _heart_prefabs = new List<GameObject>();
    [SerializeField] private GameObject _deathPanel;
    private int _deathCounter = 0;

    [SerializeField] protected GameObject heart_image;

    private void Awake() => EventSystem.singleton.AddingHpTrigger += AddingHP;

    private void OnTriggerEnter()
    {
        _deathCounter++;
        _heart_prefabs[_heart_numbers - _deathCounter].SetActive(false);
        if (_deathCounter == _heart_numbers)
        {
            Time.timeScale = 0;
            _deathPanel.SetActive(true);       
        }

    }
    private void AddingHP()
    {  
        _heart_prefabs[_heart_numbers].SetActive(true);
        _heart_numbers++;

    }

    
}
