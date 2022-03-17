using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class DeathManager : MonoBehaviour
{
    [SerializeField] protected int _heart_numbers = 3;
    [SerializeField] private int _max_hearts = 9;
    [SerializeField] protected List<GameObject> _heart_prefabs = new List<GameObject>();
    [SerializeField] private GameObject _deathPanel;
    private int _deathCounter = 0;



    public GameObject hero;
    private PlayerController playerController;
    public Button _pauseButton;
    public Button _timedilation;
    //Решение временное, необходимо написать свою систему через ивенты


    [SerializeField] protected GameObject heart_image;

    private void Awake()
    {
        //EventSystem.singleton.AddingHpTrigger += AddingHP;
        ////DataHolder.EventHolder += AddingHP;
        //if (EventSystem.Event_counter > _heart_numbers)
        //{
        //    AddingHP();
        //}
        for (int i = AddingHearts.Event_counter; i > _max_hearts; i--)
        {
            AddingHP(); 
        }
        playerController = hero.GetComponent<PlayerController>();
        //_heart_numbers = EventSystem.Event_counter;
    }

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.transform.childCount != 0 && collider.gameObject.CompareTag("Enemy"))
        {
            _deathCounter++;
            _heart_prefabs[_heart_numbers - _deathCounter].SetActive(false);
            if (_deathCounter == _heart_numbers)
            {
                //Time.timeScale = 0;
                playerController.enabled = false;
                _deathPanel.SetActive(true);
                _pauseButton.enabled = false;
                _timedilation.enabled = false;
                MoneyScript.AddMoney();
            }
        }
        if (collider.gameObject.transform.childCount != 0 && collider.gameObject.CompareTag("Log"))
        {
            //Time.timeScale = 0;
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
