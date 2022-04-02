using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assets.Scripts.Interfaces;

public class ObjectDestroyer : MonoBehaviour, IDestroyable
{
    private GameObject _player_prefab;

    private void Awake()
    {
       _player_prefab = GameObject.Find("Camera");
    }

    private void Update()
    {
        Destroy();
    }

    public void Destroy()
    {
        if (gameObject.transform.position.z + 60 < _player_prefab.transform.position.z)
        {
            Destroy(gameObject);
        }
    }
}