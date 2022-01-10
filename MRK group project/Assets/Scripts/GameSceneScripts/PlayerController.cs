using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Vector3 destinationPoint;

    public float Speed;
    public float acceleration;
    void FixedUpdate()
    {
        transform.Translate(destinationPoint * Speed);        
        if (Speed < 1.25f)
        {
            Speed += acceleration;
        }
    }
}
