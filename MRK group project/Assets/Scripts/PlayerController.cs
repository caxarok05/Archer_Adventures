using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Vector3 destinationPoint;

    public float Speed;
    void FixedUpdate()
    {
        transform.Translate(destinationPoint * Speed);
    }
    
        
    

}
