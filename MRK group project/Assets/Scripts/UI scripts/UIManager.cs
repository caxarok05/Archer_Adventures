using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;                 


public class UIManager: MonoBehaviour
{
    public void LoadScene(int sceneNumber)                  
    {
        SceneManager.LoadScene(sceneNumber);
        Time.timeScale = 1;
    }

    public void Exit()                              
    {
        Application.Quit();
    }

    public void PanelOff(GameObject PausePanel)
    {
        if (PausePanel.activeSelf == true)
        {
            Time.timeScale = 1;
            PausePanel.SetActive(false);
        }
    }

    public void PanelOn(GameObject PausePanel)
    {
        if (PausePanel.activeSelf == false)
        {
            Time.timeScale = 1;
            PausePanel.SetActive(true);
        }
    }


}
