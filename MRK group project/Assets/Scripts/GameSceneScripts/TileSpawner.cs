using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileSpawner : MonoBehaviour
{
    [SerializeField] private GameObject[] tilePrefabs;
    private List<GameObject> activeTiles = new List<GameObject>();
    private float spawnPos = 0;
    private float tileLength = 40;


    [SerializeField] private Transform player;
    private int startTiles = 10;

    
    void Start()
    {
        for (int i = 0; i < startTiles; i++)
        {
            SpawnTile(0);
        }
    }

    void Update()
    {
        if (player.position.z - 55 > spawnPos - (startTiles * tileLength))
        {
            //SpawnTile(Random.Range(0, tilePrefabs.Length));
            SpawnTile(0);
            Invoke("DeleteTile", 3f);
           
        }
    }

    private void SpawnTile(int tileIndex)
    {
        GameObject nextTile = Instantiate(tilePrefabs[tileIndex], transform.forward * spawnPos, transform.rotation);
        activeTiles.Add(nextTile);
        spawnPos += tileLength;
    }
    private void DeleteTile()
    {
        Destroy(activeTiles[0]);
        activeTiles.RemoveAt(0);
    }
}


