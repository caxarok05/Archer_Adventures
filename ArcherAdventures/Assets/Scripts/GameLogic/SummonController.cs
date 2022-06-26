using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assets.Scripts.Interfaces;

public class SummonController : MonoBehaviour, IClickable
{

    private GameObject _player;


    private void Awake()
    {
        _player = GameObject.Find("hero");
    }

    private void Update()
    {
        transform.LookAt(_player.transform);
    }
    private void OnMouseDown()
    {
        Interact();
    }

    public void Interact()
    {
        gameObject.GetComponent<ArrowSpawner>().CreateArrow(_player.transform, gameObject.transform.Find("ArrowAim").gameObject);       
    }

}
