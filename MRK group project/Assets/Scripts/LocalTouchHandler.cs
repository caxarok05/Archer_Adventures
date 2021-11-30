using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LocalTouchHandler : MonoBehaviour
{
    ScoreScript ScoreScript;
    void Start()
    {
        ScoreScript = Camera.main.GetComponent<ScoreScript>();
    }
    void OnMouseButton()
    {
        ScoreScript.score++;
        Destroy(gameObject);
    }
}
