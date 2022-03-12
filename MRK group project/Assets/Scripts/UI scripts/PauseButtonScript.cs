using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public enum MenuStatus
{
    Closed = 0,
    Opened = 1,
}
public class PauseButtonScript : MonoBehaviour
{
    [SerializeField] private Button _timedilation;
    [SerializeField] private GameObject _pausePanel;
    private static MenuStatus _status = MenuStatus.Closed;
   
    public void PanelToggle()
    {
        if (_status == MenuStatus.Opened)
        {
            Time.timeScale = 1;
            _pausePanel.SetActive(false);
            _status = MenuStatus.Closed;
        }
        else
        {
            Time.timeScale = 0;
            _pausePanel.SetActive(true);
            _status = MenuStatus.Opened;
            _timedilation.enabled = false;
        }
    }

    public void ChangeStatus(int status)
    {
            _status = (MenuStatus)status;
        
        
    }
}
