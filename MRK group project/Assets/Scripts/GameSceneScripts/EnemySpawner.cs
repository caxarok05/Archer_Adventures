using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    
    public float spawn_delay = 0.005f;

    [SerializeField] private List<GameObject> prefab = new List<GameObject>();
    //public GameObject prefab;

    public Transform spawn_point;

    public Vector3 volume;

    public int spawn_count = 10;

    void Update()
    {
        StartCoroutine("Enemy_spawner");
    }

    IEnumerator Enemy_spawner()
    {

        while (spawn_count > 0)
        {
            GameObject prefabs = prefab[Random.Range(0, prefab.Count)];
              
            Vector3 pos = new Vector3(spawn_point.position.x, spawn_point.position.y, Random.Range(spawn_point.position.z - volume.z, spawn_point.position.z + volume.z));
            if (true)
            {

            }
            GameObject obj = Instantiate(prefabs, pos, Quaternion.identity);
            spawn_count--;
            yield return new WaitForSeconds(spawn_delay);
        }

    }
}
