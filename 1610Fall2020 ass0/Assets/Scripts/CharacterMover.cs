using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMover : MonoBehaviour
{
    public CharacterController controller;

    public Vector3 moveDirection;

    private void Update()
    {
        var movement = moveDirection * Time.deltaTime;
        controller.Move(movement);
    }
}
