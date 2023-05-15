using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spin : MonoBehaviour
{
    private float position = 0;
    public float speed = 6f;
    private Vector3 speedVec;
    // Start is called before the first frame update
    void Start()
    {
        speedVec = new Vector3(0, 0, speed);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        position = position + speed;
        transform.eulerAngles += speedVec;

        if(position > 360 + 20)
        {
            print("miss");
            position = transform.eulerAngles.z;
            // Destroy(gameObject);
        }
    }
}
