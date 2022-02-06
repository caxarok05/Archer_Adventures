using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventSystem : MonoBehaviour
{
    public static EventSystem singleton;
    private void Awake()
    {
        singleton = this;
    }

    public event Action AddingHpTrigger;
    public void Adding_Hp()
    {
        if (AddingHpTrigger != null)
        {
            AddingHpTrigger();
        }
        
    }
}
