using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnvironmentSpawner : MonoBehaviour
{

    public float spawn_delay = 0.005f;

    [SerializeField] private List<GameObject> prefab_flower = new List<GameObject>();
    [SerializeField] private List<GameObject> prefab_tree = new List<GameObject>();

    public Transform spawn_point_flowers;
    public Transform spawn_point_trees;

    public Vector3 volume;

    public int spawn_count_trees = 10;
    public int spawn_count_flowers = 10;

    void Update()
    {
        StartCoroutine("Flower_spawner");
        StartCoroutine("Tree_spawner");
    }

    IEnumerator Flower_spawner()
    {

        while (spawn_count_flowers > 0)
        {
            GameObject prefabs = prefab_flower[Random.Range(0, prefab_flower.Count)];
            spawn_count_flowers--;
            Vector3 pos = new Vector3(Random.Range(spawn_point_flowers.position.x - volume.x, spawn_point_flowers.position.x + volume.x), spawn_point_flowers.position.y, Random.Range(spawn_point_flowers.position.z - volume.z, spawn_point_flowers.position.z + volume.z));
            GameObject obj = Instantiate(prefabs, pos, Quaternion.identity);

            yield return new WaitForSeconds(spawn_delay);
        }

    }
    IEnumerator Tree_spawner()
    {

        while (spawn_count_trees > 0)
        {
            GameObject prefabs = prefab_tree[Random.Range(0, prefab_tree.Count)];
            spawn_count_trees--;
            Vector3 pos = new Vector3(spawn_point_trees.position.x, spawn_point_trees.position.y, Random.Range(spawn_point_trees.position.z - volume.z, spawn_point_trees.position.z + volume.z));
            GameObject obj = Instantiate(prefabs, pos, Quaternion.identity);

            yield return new WaitForSeconds(spawn_delay);
        }

    }
}
