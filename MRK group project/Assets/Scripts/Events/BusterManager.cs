using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BusterManager : MonoBehaviour
{
    //public static EventSystem singleton;
    //private void Awake()
    //{
    //    singleton = this;
    //}

    //public event Action AddingHpTrigger;
    public static int Event_counter = 3;
    public void Adding_Hp()
    {
        //if (AddingHpTrigger != null)
        //{
        //    AddingHpTrigger();

        //}
        //DataHolder.EventHolder += AddingHpTrigger;
        BusterManager.Event_counter++;
        //Debug.Log(Event_counter);

    }
}
