using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    private float speed = 20.0f;
    private float turnSpeed = 25.0f;
    private float horizontalInput;
    private float forwardInput;

    public string inputID;


    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal" + inputID);
        forwardInput = Input.GetAxis("Vertical" + inputID);
        // moves the car forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        //rotates the car based on horizontal input
        transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime);
    }

}
