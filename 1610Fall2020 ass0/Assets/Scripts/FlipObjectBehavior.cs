﻿using System;
using UnityEngine;

public class FlipObjectBehavior : MonoBehaviour
{
    public float rotateValue;
    private void Update()
    {

        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            rotateValue = 180;
        }
        
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            rotateValue = 0;
        }
        
        transform.rotation = Quaternion.Euler(0, rotateValue, 0);
    }
}
