using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class Defence : Collectible
{
    public float powerLevel = .5f;

    public override void Use()
    {
       Debug.Log(this.name); 
    }
}
