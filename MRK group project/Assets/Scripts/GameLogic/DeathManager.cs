using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class DeathManager : MonoBehaviour
{
    [Header("Heart System")]

    [SerializeField] protected int _heart_numbers = 3;
    [SerializeField] private int _max_hearts = 9;
    [SerializeField] protected List<GameObject> _heart_prefabs = new List<GameObject>();
    private int _deathCounter = 0;   

    [Header ("UI")]

    [SerializeField] private GameObject _deathPanel;
    [SerializeField] private GameObject hero; 
    [SerializeField] private Button _pauseButton;
    [SerializeField] private Button _timedilation;
    [SerializeField] protected GameObject heart_image;

    private PlayerController playerController;

    private void Awake()
    {
        for (int i = AddingHearts.Event_counter; i > _max_hearts; i--)
        {
            AddingHP(); 
        }
        playerController = hero.GetComponent<PlayerController>();
    }

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.transform.childCount != 0 && collider.gameObject.CompareTag("Enemy"))
        {
            _deathCounter++;
            _heart_prefabs[_heart_numbers - _deathCounter].SetActive(false);
            if (_deathCounter == _heart_numbers)
            {
                playerController.enabled = false;
                _deathPanel.SetActive(true);
                _pauseButton.enabled = false;
                _timedilation.enabled = false;
                MoneyScript.AddMoney();
            }
        }
        if (collider.gameObject.transform.childCount != 0 && collider.gameObject.CompareTag("Log"))
        {
            playerController.enabled = false;
            _deathPanel.SetActive(true);
            _pauseButton.enabled = false;
            _timedilation.enabled = false;
            MoneyScript.AddMoney();
        }
        

    }
    private void AddingHP()
    {  
        _heart_prefabs[_heart_numbers].SetActive(true);
        _heart_numbers++;

    }

    
}
