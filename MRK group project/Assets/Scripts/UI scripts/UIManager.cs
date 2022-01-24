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

    public void PausePanelOn(GameObject PausePanel)
    {
        Time.timeScale = 0;
        PausePanel.SetActive(true);
    }

    public void PausePanelOff(GameObject PausePanel)
    {
        Time.timeScale = 1;
        PausePanel.SetActive(false);
    }
}
