using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

public class DontDestroyMusicScript : MonoBehaviour
{
    //[SerializeField] private AudioSource _bgMusic;
    public string _bgTag;

    private void Awake()
    {
        GameObject obj = GameObject.FindWithTag(_bgTag);
        if (obj != null)
        {
            Destroy(gameObject);
        }
        else
        {
            gameObject.tag = _bgTag;
            DontDestroyOnLoad(gameObject);
        }
    }

    private void Update()
    {
        if (SceneManager.GetActiveScene().name == "MenuScene")
        {
            Destroy(gameObject);
        }
    }
}
