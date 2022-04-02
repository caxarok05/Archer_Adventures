using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowFPS : MonoBehaviour
{
    public static float Fps;

    void OnGUI()
    {
        Fps = 1.0f / Time.deltaTime;
        GUILayout.Label("FPS: " + (int)Fps);
    }
}
