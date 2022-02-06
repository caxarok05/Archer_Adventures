using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    void Update()
    {
        var target = GameObject.Find("hero");
        transform.LookAt(target.transform);
        
    }
    void OnMouseDown()
    {
        
        ScoreScript.Instance.score++;
        Destroy(gameObject);
    }

}
