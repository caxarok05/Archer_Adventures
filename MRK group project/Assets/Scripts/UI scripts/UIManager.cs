using System.Collections;
using System.Collections.Generic;
using UnityEngine;
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

    public void PanelOn(GameObject PausePanel)
    {
        Time.timeScale = 0;
        PausePanel.SetActive(true);
    }

    public void PanelOff(GameObject PausePanel)
    {
        Time.timeScale = 1;
        PausePanel.SetActive(false);
    }
}
