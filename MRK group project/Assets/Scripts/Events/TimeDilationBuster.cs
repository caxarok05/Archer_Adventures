using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeDilationBuster : MonoBehaviour
{
    [SerializeField] private Button TimeDilationButton;
    private int _timeDilationCounter = 2;

    public void TimeDilation()
    {
        if (_timeDilationCounter != 0 && TimeDilationButton.interactable == true)
        {
            TimeDilationButton.interactable = false;
            _timeDilationCounter--;
            Time.timeScale = 0.4f;
            Invoke("ReturnTime", 0.8f);

        }
    }

    private void Awake()
    {
        TimeDilationButton.interactable = false;
        if (BuyTimeDilationScript._currentUpgrade > 0)
        {
            TimeDilationButton.interactable = true;
        }
    }
    private void Update()
    {
        if (_timeDilationCounter == 0)
        {
            TimeDilationButton.interactable = false;
        }
    }

    private void ReturnTime()
    {
        Time.timeScale = 1;
        //TimeShiftText.text = $"{TimeShiftCounter}/2";
        TimeDilationButton.interactable = true;
    }

}
