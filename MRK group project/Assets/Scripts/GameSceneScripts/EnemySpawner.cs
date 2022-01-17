using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private List<GameObject> _prefabs = new List<GameObject>();
    [SerializeField] private Transform _spawn_point;
    [SerializeField] private float _volume_Z;
    
    private int _spawn_count = 1;
    private float _spawn_delay = 0.005f;

    private void Update()
    {
        StartCoroutine("Enemy_spawner");
    }

    IEnumerator Enemy_spawner()
    {

        while (_spawn_count > 0)
        {
            GameObject prefab = _prefabs[Random.Range(0, _prefabs.Count)];
            Vector3 pos = new Vector3(_spawn_point.position.x, _spawn_point.position.y, Random.Range(_spawn_point.position.z - _volume_Z, _spawn_point.position.z + _volume_Z));
            GameObject obj = Instantiate(prefab, pos, Quaternion.identity);
            _spawn_count--;
            yield return new WaitForSeconds(_spawn_delay);
        }

    }
}
