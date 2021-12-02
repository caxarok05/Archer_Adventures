using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LocalTouchHandler : MonoBehaviour
{
    

    void OnMouseDown()
    {
        ScoreScript.Instance.score++;
        Destroy(gameObject);
    }
}
