using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;                 

public class SceneManagerScript : MonoBehaviour
{
    public void ChooseScene(int sceneNumber)                  // Метод смены сцены с номером сцены
    {
        SceneManager.LoadScene(sceneNumber);                  // Выбор сцены (а может быть сценой 1, 2, 3 и т.д. - ну, там build setting и тд)
    }

    public void Exit()                              // Метод выхода из приоложения
    {
        Application.Quit();                         // Сам выход
    }

}
