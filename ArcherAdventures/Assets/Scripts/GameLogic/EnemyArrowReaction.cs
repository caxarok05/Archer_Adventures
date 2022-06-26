using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyArrowReaction : MonoBehaviour
{

    [SerializeField] private List<AudioClip> _deathSounds = new List<AudioClip>();
    private AudioSource _enemyAudioSource;
    private BoxCollider _enemyCollider;
    private ParticleSystem _particles;

    private void Awake()
    {
        _particles = gameObject.transform.GetComponentInChildren<ParticleSystem>();
        _enemyAudioSource = gameObject.GetComponent<AudioSource>();
        _enemyCollider = gameObject.GetComponent<BoxCollider>();
    }


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("ArrowTag"))
        {
            _particles.Play();
            ScoreScript.Instance.score++;
            _enemyAudioSource.PlayOneShot(_deathSounds[Random.Range(0, _deathSounds.Count)]);
            Destroy(gameObject.transform.Find("EnemyChild").gameObject);
            _enemyCollider.enabled = false;
            Destroy(collision.gameObject.transform.parent.gameObject);
        }
    }
}
