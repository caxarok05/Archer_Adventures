using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDestroyer : MonoBehaviour
{
    private GameObject Player_prefab;

    private void Start()
    {
        Player_prefab = GameObject.Find("hero");
    }
    private void Update()
    {
        if (gameObject.transform.position.z + 30 < Player_prefab.transform.position.z)
        {
            Destroy(gameObject);
        }
    }
}
