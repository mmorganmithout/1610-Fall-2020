using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEditorInternal;
using UnityEngine;

public class MoverScript : MonoBehaviour
{
    public float moveSpeed;
    private Vector3 moveDirection;
    
    
    public void Update()
    {
        if (Input.GetButton("Jump"))
        {
            moveDirection.x = moveSpeed * Time.deltaTime;
        }
        else
        {
            moveDirection.x = -moveSpeed * Time.deltaTime;
        }

        transform.Translate(moveDirection);
    }
}
