﻿using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class CoroutineBehaviour : MonoBehaviour
{
    public UnityEvent startEvent, repeatEvent, endEvent;
    public float holdTime, repeatHoldTime = 0.25f;
    public int counter = 3;

    public void RunCoroutine()
    {
        StartCoroutine(Corountine());
    }

    private IEnumerator Corountine()
    {
        startEvent.Invoke();
        
        yield return new WaitForSeconds(holdTime);

        while (counter > 0)
        {
            repeatEvent.Invoke();
            yield return new WaitForSeconds(repeatHoldTime);
            counter--;
        }
        
        yield return new WaitForSeconds(holdTime);
        endEvent.Invoke();
    }
}