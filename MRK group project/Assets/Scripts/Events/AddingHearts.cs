using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AddingHearts : MonoBehaviour
{


    //public static EventSystem singleton;
    //private void Awake()
    //{
    //    singleton = this;
    //}

    //public event Action AddingHpTrigger;
    private static int PressLimit = 0;
    public static int Event_counter = 3;
    public Button AddHPButton;

    private void Start()
    {
        if (PressLimit >= 6)
        {
            AddHPButton.interactable = false;
        }
    }
    public void Adding_Hp()
    {
        if (PressLimit >= 6)
        {
            AddHPButton.interactable = false;
        }
        else
        {
            AddingHearts.Event_counter++;
            PressLimit++;
        }
        
        //if (AddingHpTrigger != null)
        //{
        //    AddingHpTrigger();

        //}
        //DataHolder.EventHolder += AddingHpTrigger;
        
        //Debug.Log(Event_counter);

    }

    
}
