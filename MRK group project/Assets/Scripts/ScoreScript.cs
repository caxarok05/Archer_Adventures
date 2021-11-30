using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    public int score;

    public Text ScoreText;
 
    void Update()
    {
        ScoreText.text = "Score: " + score;
    }
}
