using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assets.Scripts.Interfaces;

public class EnemyController : MonoBehaviour, IClickable
{

    [SerializeField] private List<AudioClip> _deathSounds = new List<AudioClip>();
    private AudioSource _enemyAudioSource;
    private GameObject _player;
    private CapsuleCollider _enemyCollider;


    private void Awake()
    {
        _enemyAudioSource = gameObject.GetComponent<AudioSource>();
        _enemyCollider = gameObject.GetComponent<CapsuleCollider>();
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

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("ArrowTag"))
        {
            ScoreScript.Instance.score++;
            _enemyAudioSource.PlayOneShot(_deathSounds[Random.Range(0, _deathSounds.Count)]);
            Destroy(gameObject.transform.Find("EnemyChild").gameObject);
            _enemyCollider.enabled = false;
            Destroy(collision.gameObject);
        }
    }

    public void Interact()
    {
        gameObject.GetComponent<ArrowSpawner>().CreateArrow(_player.transform, gameObject);
        
    }

}
