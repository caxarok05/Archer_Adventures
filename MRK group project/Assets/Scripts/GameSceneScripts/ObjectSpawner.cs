using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public  class ObjectSpawner : MonoBehaviour
{
    
    protected List<GameObject> Prefabs = new List<GameObject>();
    protected Transform Spawn_point;
    protected float Volume_Z;
    protected static float Spawn_delay = 0.005f;
    protected int Spawn_count;

    protected virtual void Object_Spawner()
    {
       
    }

}
