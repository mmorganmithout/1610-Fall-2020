using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class AmmoUp : MonoBehaviour
{
    public int ammo;
    public UnityEvent ammoUpEvent;

    public void OnTriggerEnter(Collider other)
    {
        ammo++;
        print(ammo);
        ammoUpEvent.Invoke();
    }
}
