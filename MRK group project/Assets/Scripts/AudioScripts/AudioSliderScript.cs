using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
public class AudioSliderScript : MonoBehaviour
{
    [Header("Components")]
    [SerializeField] private Slider _slider;
    [SerializeField] private AudioSource _audio;
    [SerializeField] private Text _text;

    [Header("Keys")]
    [SerializeField] private string _saveVolumeKey;

    [Header("Tags")]
    [SerializeField] private string _sliderTag;
    [SerializeField] private string _textVolumeTag;

    [Header("Parameters")]
    [SerializeField] private float _volume;


    private void Awake()
    {
        if (PlayerPrefs.HasKey(_saveVolumeKey))
        {
            _volume = PlayerPrefs.GetFloat(_saveVolumeKey);
            _audio.volume = _volume;

            GameObject sliderObj = GameObject.FindWithTag(_sliderTag);
            if (sliderObj != null) 
            {
                _slider = sliderObj.GetComponent<Slider>();
                _slider.value = _volume;
            }
        }
        else
        {
            _volume = 0.5f;
            PlayerPrefs.SetFloat(_saveVolumeKey, _volume);
            _audio.volume = _volume;
        }
    }

    private void LateUpdate()
    {
        GameObject sliderObj = GameObject.FindWithTag(_sliderTag);
        if (sliderObj != null)
        {
            _slider = sliderObj.GetComponent<Slider>();
            _volume = _slider.value;

            if (_audio.volume != _volume)
            {
                PlayerPrefs.GetFloat(_saveVolumeKey, _volume);
            }

            GameObject textObj = GameObject.FindWithTag(_textVolumeTag);
            if (textObj != null)
            {
                _text.text = Mathf.Round(_volume * 100) + "%";
            }
        }
        _audio.volume = _volume;
    }

}
