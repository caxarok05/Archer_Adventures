using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelOFFScript : MonoBehaviour
{
    [SerializeField] private GameObject _pausePanel;

    public void PanelOff()
    {
        if (_pausePanel.activeSelf == true)
        {
            Time.timeScale = 1;
            _pausePanel.SetActive(false);
        }
    }
}
