using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SummonSpawner : MonoBehaviour
{
    [SerializeField] private List<GameObject> _summonPrefab = new List<GameObject>();
    [SerializeField] private Transform _spawnPointSummon;
    [SerializeField] private float _volumeZ;
    
    private int _spawnCountSummon = 1;

    private void Update()
    {
        Enemy_spawner();
    }

    protected void Enemy_spawner()
    {

        while (_spawnCountSummon > 0)
        {
            GameObject prefab = _summonPrefab[Random.Range(0, _summonPrefab.Count)];
            Vector3 pos = new Vector3(_spawnPointSummon.position.x, _spawnPointSummon.position.y, Random.Range(_spawnPointSummon.position.z - _volumeZ, _spawnPointSummon.position.z + _volumeZ));
            Instantiate(prefab, pos, Quaternion.identity);
            _spawnCountSummon--;
        }

    }
}
