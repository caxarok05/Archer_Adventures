using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DeathTimer : MonoBehaviour
{
    [SerializeField] private Image _loadingCircle;
    [SerializeField] private Text _loadingText;
    private  float _deathTimer = 5;

    private void Update()
    {
        _deathTimer -= Time.deltaTime;
        _loadingText.text = Mathf.Round(_deathTimer).ToString();
        _loadingCircle.fillAmount = _deathTimer / 5;

        if (_deathTimer <= 0)
        {
            SceneManager.LoadScene(0);
        }
    }
}
