using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PeacefullManArrowReaction : MonoBehaviour
{

    [SerializeField] private List<AudioClip> _deathSounds = new List<AudioClip>();
    private AudioSource _peacefullManAudioSource;
    private BoxCollider _peacefullManCollider;
    private ParticleSystem _particles;

    private DeathManager _deathManager;

    private void Awake()
    {
        _particles = gameObject.transform.GetComponentInChildren<ParticleSystem>();
        _peacefullManAudioSource = gameObject.GetComponent<AudioSource>();
        _peacefullManCollider = gameObject.GetComponent<BoxCollider>();
        _deathManager = GameObject.FindGameObjectWithTag("death_colider").GetComponent<DeathManager>();
    }


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("ArrowTag"))
        {
            _particles.Play();
            _deathManager.LoseHP();
            _peacefullManAudioSource.PlayOneShot(_deathSounds[Random.Range(0, _deathSounds.Count)]);
            Destroy(gameObject.transform.Find("PeaceFullManChild").gameObject);
            _peacefullManCollider.enabled = false;
            Destroy(collision.gameObject.transform.parent.gameObject);
        }
    }
}
