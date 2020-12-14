using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OldMoverScript : MonoBehaviour
{
    public float speed = 3f;
    public float x, y, z;
    public int score = 100;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello World!");
    }

    // Update is called once per frame
    void Update()
    {
        x = speed*Input.GetAxis("Horizontal")*Time.deltaTime;
        y = speed*Input.GetAxis("Vertical")*Time.deltaTime;
        transform.Translate(x,y,z);
    }

    public void Up()
    {
        print("Up");
        transform.Translate(0,speed,0);
    }

    public void Down()
    {
        print("Down");
        transform.Translate(0,-speed,0);
    }
}
