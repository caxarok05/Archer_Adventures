using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowSpawner : MonoBehaviour
{
    [SerializeField] private GameObject _arrowPrefab;
    [SerializeField] private float _shotHeight;

    public static GameObject EnemyPos;

    public void CreateArrow(Transform player, GameObject arrowAim)
    {
        Instantiate(_arrowPrefab, new Vector3(player.transform.position.x, player.transform.position.y + _shotHeight, player.transform.position.z), Quaternion.identity);
        EnemyPos = arrowAim;

    }
}
