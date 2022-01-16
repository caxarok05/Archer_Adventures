using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileSpawner : MonoBehaviour
{
    [SerializeField] private GameObject _tilePrefab;
    [SerializeField] private float _tileLength = 40;
    [SerializeField] private Transform _player;

    private float _spawnPos = 0;
    private int _startTiles = 10;

    private void Update()
    {
        if (_player.position.z > _spawnPos - (_tileLength * _startTiles))
        {
            SpawnTile();        
        }  
    }

    private void SpawnTile()
    {
        GameObject nextTile = Instantiate(_tilePrefab, transform.forward * _spawnPos, transform.rotation);
        _spawnPos += _tileLength;
    }
}


