using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowSpawner : MonoBehaviour
{
    public static GameObject EnemyPos;

    [SerializeField] private GameObject _arrowPrefab;

    public void CreateArrow(Transform player, GameObject arrowAim)
    {
        Instantiate(_arrowPrefab, player.position , Quaternion.identity);
        EnemyPos = arrowAim;
        
    }
}
