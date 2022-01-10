using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnemyController : MonoBehaviour
{
    private int deathCounter = 0;
    private GameObject target;

    void Update()
    {

        var target = GameObject.Find("hero");
        transform.LookAt(target.transform);
        if (deathCounter == 3)
        {
            Debug.Log("Ты мёртв!");
        }
    }

    private int OnTriggerEnter(Collider other)
    {
        deathCounter++;
        Debug.Log(deathCounter);
        return deathCounter;
        
    }
    void OnMouseDown()
    {
        ScoreScript.Instance.score++;
        Destroy(gameObject);
    }

}
