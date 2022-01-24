using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathManager : MonoBehaviour
{
    [SerializeField] private int _heart_numbers = 3;
    [SerializeField] private List<GameObject> _heart_prefabs = new List<GameObject>();
    [SerializeField] private GameObject _deathPanel;
    private int _deathCounter = 0;

    //private void Awake()
    //{
    //    for (int i = 0; i < _heart_prefabs.Count; i++)
    //    {
    //        _heart_prefabs[i] = GameObject.Find($"Health image ({i})");
    //    }
       
    //}

    private void OnTriggerEnter()
    {
        _deathCounter++;
        _heart_prefabs[_heart_numbers - _deathCounter].SetActive(false);
        //_heart_prefabs.RemoveAt(_heart_numbers - _deathCounter);
        if (_deathCounter == 3)
        {
            Time.timeScale = 0;
            _deathPanel.SetActive(true);       
        }

    }
}
