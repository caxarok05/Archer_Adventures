using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeDilationBuster : MonoBehaviour
{
    [SerializeField] private Button TimeDilationButton;
    private int _timeShiftCounter = 2;

    public void TimeDilation()
    {
        if (_timeShiftCounter != 0 && TimeDilationButton.interactable == true)
        {
            TimeDilationButton.interactable = false;
            _timeShiftCounter--;
            Time.timeScale = 0.4f;
            Invoke("ReturnTime", 0.8f);

        }
    }

    private void Update()
    {
        if (_timeShiftCounter == 0)
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
