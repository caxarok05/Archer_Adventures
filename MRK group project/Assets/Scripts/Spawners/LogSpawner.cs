using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogSpawner : MonoBehaviour
{
    [SerializeField] private GameObject _prefab_log;
    [SerializeField] private Transform _spawn_point_log;
    [SerializeField] private float _volume_Z;
    [SerializeField] private static int _logChance = 30;


    //private Quaternion log_angle = log_angle.Set(Quaternion.identity.x, Quaternion.identity.y, Quaternion.identity.z, Quaternion.identity.w);
    private int _spawnCountLogs = 1;
    private bool _isSpawned;

    private void Start()
    {
        _isSpawned = Random.Range(0, 100) < _logChance;
    }
    private void Update()
    {
        Log_spawner();
    }

    protected void Log_spawner()
    {
            while (_isSpawned && _spawnCountLogs > 0)
            {
                Vector3 pos = new Vector3(_spawn_point_log.position.x, _spawn_point_log.position.y, Random.Range(_spawn_point_log.position.z - _volume_Z, _spawn_point_log.position.z + _volume_Z));
                Quaternion log_angle = new Quaternion(Quaternion.identity.x, Random.Range(-20, 20), Quaternion.identity.z, Quaternion.identity.w);
                Instantiate(_prefab_log, pos, log_angle);
                _spawnCountLogs--;
            }
    }
}
