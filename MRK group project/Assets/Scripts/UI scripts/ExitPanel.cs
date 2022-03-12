using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitPanel : MonoBehaviour
{
    [SerializeField] private GameObject _exitPanel;
    void Update()
    {
        if (Application.platform == RuntimePlatform.Android)
        {
            if (Input.GetKey(KeyCode.Home) || Input.GetKey(KeyCode.Escape) || Input.GetKey(KeyCode.Menu))
            {
                _exitPanel.SetActive(true);
            }
        }
        //    if (Input.GetKeyUp(KeyCode.Escape))
        //{
        //    _exitPanel.SetActive(true);
        //}
    }

    public void ExitPanelClose()
    {
        _exitPanel.SetActive(false);
        //if (_exitPanel.activeSelf == true)
        //{
        //    Time.timeScale = 1;
        //    _exitPanel.SetActive(false);
        //}
    }
}
