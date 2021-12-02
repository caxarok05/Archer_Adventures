using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnvironmentSpawner : MonoBehaviour
{

    public float spawn_delay = 0.005f;

    [SerializeField] private List<GameObject> prefab = new List<GameObject>();

    public Transform spawn_point;

    public Vector3 volume;

    public int spawn_count = 10;

    void Update()
    {
        StartCoroutine("Flower_spawner");

    }

    IEnumerator Flower_spawner()
    {

        while (spawn_count > 0)
        {
            GameObject prefabs = prefab[Random.Range(0, prefab.Count)];
            spawn_count--;
            Vector3 pos = new Vector3(Random.Range(spawn_point.position.x - volume.x, spawn_point.position.x + volume.x), spawn_point.position.y, Random.Range(spawn_point.position.z - volume.z, spawn_point.position.z + volume.z));
            GameObject obj = Instantiate(prefabs, pos, Quaternion.identity);

            yield return new WaitForSeconds(spawn_delay);
        }

    }
}
