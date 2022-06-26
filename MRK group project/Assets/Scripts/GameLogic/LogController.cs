using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assets.Scripts.Interfaces;

public class LogController : MonoBehaviour, IClickable
{
    [SerializeField] private AudioClip _deathSound;
    [SerializeField] private AudioSource _logAudioSource;
    private ParticleSystem _particles;
    private GameObject _player;
    private void Awake()
    {
        _particles = transform.GetComponentInChildren<ParticleSystem>();
        _logAudioSource = GetComponent<AudioSource>();
        _player = GameObject.Find("hero");
    }
    private void OnMouseDown()
    {
        Interact();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("ArrowTag"))
        {
            _particles.Play();
            ScoreScript.Instance.score++;
            _logAudioSource.PlayOneShot(_deathSound);
            Destroy(gameObject.transform.Find("LogChild").gameObject);
            GetComponent<Collider>().enabled = false;
            Destroy(collision.gameObject.transform.parent.gameObject);
        }
    }

    public void Interact()
    {
        gameObject.GetComponent<ArrowSpawner>().CreateArrow(_player.transform, gameObject);
    }

}
