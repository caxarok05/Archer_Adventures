using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    [SerializeField] private List<AudioClip> _deathSounds = new List<AudioClip>();
    private AudioSource _enemyAudioSource;
    private GameObject _target;
    private CapsuleCollider _enemyCollider;
    private void Awake()
    {
        _enemyAudioSource = gameObject.GetComponent<AudioSource>();
        _enemyCollider = gameObject.GetComponent<CapsuleCollider>();
        _target = GameObject.Find("hero");
    }
    void Update()
    {
        transform.LookAt(_target.transform);

    }
    void OnMouseDown()
    { 
        ScoreScript.Instance.score++;
        _enemyAudioSource.PlayOneShot(_deathSounds[Random.Range(0, _deathSounds.Count)]);
        Destroy(gameObject.transform.Find("EnemyChild").gameObject);
        _enemyCollider.enabled = false;
    }

}
