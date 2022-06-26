using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowScript : MonoBehaviour
{
    [SerializeField] private float _arrowSpeed = 1;

    private GameObject _arrowAim;

    private void Start()
    {
        _arrowAim = ArrowSpawner.EnemyPos;
    }

    private void FixedUpdate()
    {
        ShootArrow();
    }

    private void ShootArrow()
    {
        if (_arrowAim != null)
        {
            gameObject.transform.LookAt(_arrowAim.transform);
            gameObject.transform.Translate(_arrowAim.transform.position.normalized * _arrowSpeed);
        }           
        //if (Vector3.Distance( gameObject.transform.position, _arrowAim.transform.position) <= 2 && _arrowAim.gameObject.activeSelf == false)
        //{
        //    Destroy(gameObject);
        //}
    }
}
