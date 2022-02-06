using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private List<GameObject> _prefab_enemy = new List<GameObject>();
    [SerializeField] private Transform _spawn_point_enemy;
    [SerializeField] private float _volume_Z;
    
    private int _spawn_count_enemy = 1;

    private void Update()
    {
        Enemy_spawner();
    }

    protected void Enemy_spawner()
    {

        while (_spawn_count_enemy > 0)
        {
            GameObject prefab = _prefab_enemy[Random.Range(0, _prefab_enemy.Count)];
            Vector3 pos = new Vector3(_spawn_point_enemy.position.x, _spawn_point_enemy.position.y, Random.Range(_spawn_point_enemy.position.z - _volume_Z, _spawn_point_enemy.position.z + _volume_Z));
            Instantiate(prefab, pos, Quaternion.identity);
            _spawn_count_enemy--;
        }

    }
}
