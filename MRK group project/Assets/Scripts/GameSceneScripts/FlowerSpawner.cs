using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlowerSpawner : MonoBehaviour
{
    [SerializeField] private List<GameObject> _prefab_flower = new List<GameObject>();
    [SerializeField] private Transform _spawn_point_flowers;
    [SerializeField] private Vector3 _volume;

    private int _spawn_count_flowers = 5;
    private float _spawn_delay = 0.005f;
    
    private void Update()
    {
        Invoke("Flower_spawner", _spawn_delay);      
    }

    private void Flower_spawner()
    {
        while (_spawn_count_flowers > 0)
        {
            GameObject prefabs = _prefab_flower[Random.Range(0, _prefab_flower.Count)];
            _spawn_count_flowers--;
            Vector3 pos = new Vector3(Random.Range(_spawn_point_flowers.position.x - _volume.x, _spawn_point_flowers.position.x + _volume.x), _spawn_point_flowers.position.y, Random.Range(_spawn_point_flowers.position.z - _volume.z, _spawn_point_flowers.position.z + _volume.z));
            GameObject obj = Instantiate(prefabs, pos, Quaternion.identity);
           
        }
    }
}
