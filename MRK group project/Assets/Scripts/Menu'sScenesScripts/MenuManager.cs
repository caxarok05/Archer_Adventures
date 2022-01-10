using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManager : MonoBehaviour
{
    public GameObject PausePanel;
    public void PauseScene(GameObject PausePanel)
    {
        Time.timeScale = 0;
        PausePanel.SetActive(true);
    }

    public void ContinueScene(GameObject PausePanel)
    {
        Time.timeScale = 1;
        PausePanel.SetActive(false);
    }
}
