using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class HealthPowerUp : MonoBehaviour
{
    public int health;
    public UnityEvent healthUpEvent;

    private void OnTriggerEnter(Collider other)
    {
        health++;
        print(health);
        healthUpEvent.Invoke();
    }
}
