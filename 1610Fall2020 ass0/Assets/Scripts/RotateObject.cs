using System;
using UnityEngine;

public class RotateObject : MonoBehaviour
{
    public float rotateSpeed = 45f;
    public bool canRotate;

    public void ChangeCanRotate(bool can)
    {
        canRotate = can;
    }
    private void Update()
    {
        if (canRotate)
        {
            var finalSpeed = rotateSpeed * Time.deltaTime;
            transform.Rotate(0, 0, finalSpeed);
        }
    }
}