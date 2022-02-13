using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchHandler : MonoBehaviour
{
    void OnMouseDown()
    {
        ScoreScript.Instance.score++;
        Destroy(gameObject);
    }

}
