using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinPropeller : MonoBehaviour
{
    private float x;
    private float z;
    private bool rotateX;
    private float rotationSpeed;

    void Start()
    {
        x = 0.0f;
        z = 0.0f;
        rotateX = true;
        rotationSpeed = 200.0f;
    }

    void FixedUpdate()
    {
        if (rotateX == true)
        {
            z += Time.deltaTime * rotationSpeed;

            if (z > 360.0f)
            {
                z = 0.0f;
                rotateX = false;
            }
        }
        else
        {
            z += Time.deltaTime * rotationSpeed;

            if (z > 360.0f)
            {
                z = 0.0f;
                rotateX = true;
            }
        }

        transform.localRotation = Quaternion.Euler(x, 0, z);
    }
}
