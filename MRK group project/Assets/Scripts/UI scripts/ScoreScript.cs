using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    public int score;

    public static ScoreScript Instance;

    public Text ScoreText;

    private void Awake()
    {
        Instance = this;
    }

    void Update()
    {
        ScoreText.text = string.Empty + score;
    }
}
