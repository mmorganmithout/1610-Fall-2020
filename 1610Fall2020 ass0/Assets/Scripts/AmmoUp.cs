using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoUp : MonoBehaviour
{
    public int ammo;

    public void OnTriggerEnter(Collider other)
    {
        ammo++;
        print(ammo);
    }
}
