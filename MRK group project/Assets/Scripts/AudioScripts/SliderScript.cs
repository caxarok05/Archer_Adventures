using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class SliderScript : MonoBehaviour
{

    [SerializeField] private AudioMixer _mixer;
    [SerializeField] private string _musicMixerGroup;
    [SerializeField] private string _sfxMixerGroup;
    [SerializeField] private Slider _musicSlider;
    [SerializeField] private Slider _sfxSlider;
    [SerializeField] private static string _musicSaveVolumeKey = "MUSIC_KEY";
    [SerializeField] private static string _sfxSaveVolumeKey = "SFX_KEY";

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










    //[Header("Components")]
    //[SerializeField] private Slider _slider;
    //[SerializeField] private AudioSource _audio;

    //[Header("Keys")]
    //

    //[Header("Parameters")]
    //[SerializeField] private float _volume;

    //private void Awake()
    //{
    //    _volume = PlayerPrefs.GetFloat(_saveVolumeKey);
    //}
    //public void ChangeVolume()
    //{
    //    _volume = _slider.value;
    //    _audio.volume = _volume;
    //    PlayerPrefs.SetFloat(_saveVolumeKey, _volume);
    //}
}
