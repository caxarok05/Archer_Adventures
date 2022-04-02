using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowScript : MonoBehaviour
{
    [SerializeField] private float _speed = 1;
    private GameObject _arrowAim;

    private void Start()
    {
        _arrowAim = ArrowSpawner.EnemyPos;
    }

    private void Update()
    {
        ShootArrow();
    }

    private void ShootArrow()
    {
        gameObject.transform.LookAt(_arrowAim.transform);
        gameObject.transform.Translate(_arrowAim.transform.position * _speed);

    }
}
