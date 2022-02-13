using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeSpawner : MonoBehaviour
{

    [SerializeField] private List<GameObject> _prefab_tree = new List<GameObject>();
    [SerializeField] private Transform _spawn_point_trees;
    [SerializeField] private Vector3 _volume;

    private int _spawn_count_trees = 2;


    private void Update()
    {
        Tree_spawner();
    }
 
    private void Tree_spawner()
    {
        while (_spawn_count_trees > 0)
        {
            GameObject prefabs = _prefab_tree[Random.Range(0, _prefab_tree.Count)];
            _spawn_count_trees--;
            Vector3 pos = new Vector3(_spawn_point_trees.position.x, _spawn_point_trees.position.y, Random.Range(_spawn_point_trees.position.z - _volume.z, _spawn_point_trees.position.z + _volume.z));
            Instantiate(prefabs, pos, Quaternion.identity);     
        }

    }
}
