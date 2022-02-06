using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float acceleration;
    [SerializeField] private float Speed = 0.7f;
    private Vector3 destinationPoint = Vector3.forward;
      
    private void FixedUpdate()
    {
        transform.Translate(destinationPoint * Speed);        
        if (Speed < 1.25f)
        {
            Speed += acceleration;
        }
    }
}
