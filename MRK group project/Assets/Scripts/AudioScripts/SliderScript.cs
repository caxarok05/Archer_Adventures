using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class SliderScript : MonoBehaviour
{
    [SerializeField] private AudioMixer _mixer;

    [Header ("SFX Volume")]

    [SerializeField] private string _sfxMixerGroup;
    [SerializeField] private Slider _sfxSlider;
    [SerializeField] private static string _sfxSaveVolumeKey = "SFX_KEY";

    [Header("Music Volume")]

    [SerializeField] private string _musicMixerGroup;    
    [SerializeField] private Slider _musicSlider;   
    [SerializeField] private static string _musicSaveVolumeKey = "MUSIC_KEY";
    

    private void Awake()
    {
        if (PlayerPrefs.HasKey(_sfxSaveVolumeKey))
        {
            _sfxSlider.value = PlayerPrefs.GetFloat(_sfxSaveVolumeKey);
            
        }
        if (PlayerPrefs.HasKey(_musicSaveVolumeKey))
        {
            _musicSlider.value = PlayerPrefs.GetFloat(_musicSaveVolumeKey);

        }

        //_musicSlider = GameObject.FindWithTag("MusicTag").GetComponent<Slider>();
        //_sfxSlider = GameObject.FindWithTag("SfxTag").GetComponent<Slider>();


    }
    public void ChangeSfx(float _volume)
    {
        _mixer.SetFloat(_sfxMixerGroup, Mathf.Log10(_volume) * 20);
        PlayerPrefs.SetFloat(_sfxSaveVolumeKey, _sfxSlider.value);
    }
    public void ChangeMusic(float _volume)
    {
        _mixer.SetFloat(_musicMixerGroup, Mathf.Log10(_volume) * 20);
        PlayerPrefs.SetFloat(_musicSaveVolumeKey, _musicSlider.value);
    }
}
