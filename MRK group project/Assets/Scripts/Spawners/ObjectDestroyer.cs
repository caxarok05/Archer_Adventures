using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectDestroyer : MonoBehaviour
{
    private GameObject _player_prefab;

    private void Awake()
    {
       _player_prefab = GameObject.Find("Camera");
    }

    private void Update()
    {
        if (gameObject.transform.position.z + 60 < _player_prefab.transform.position.z)
        {
            Destroy(gameObject);
        }
    }
}