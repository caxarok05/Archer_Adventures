using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;                 

public class SceneManagerScript : MonoBehaviour
{
   
    public void ChooseScene(int sceneNumber)                  // ����� ����� ����� � ������� �����
    {
        
        SceneManager.LoadScene(sceneNumber);                  // ����� ����� (� ����� ���� ������ 1, 2, 3 � �.�. - ��, ��� build setting � ��)
        Time.timeScale = 1;
    }

    public void Exit()                              // ����� ������ �� �����������
    {
        Application.Quit();                         // ��� �����
        
    }

}
