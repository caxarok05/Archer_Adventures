using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogController : MonoBehaviour
{
    [SerializeField] private AudioClip _deathSound;
    [SerializeField] private AudioSource _logAudioSource;
    private void Awake()
    {
        _logAudioSource = gameObject.GetComponent<AudioSource>();
    }
    private void OnMouseDown()
    {
        ScoreScript.Instance.score++;
        _logAudioSource.PlayOneShot(_deathSound);
        Destroy(gameObject.transform.Find("LogChild").gameObject);
        GetComponent<Collider>().enabled = false;
    }
}
