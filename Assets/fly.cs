using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fly : MonoBehaviour
{
    [Range(1, 10)] public float flyVelocity;

    private void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            GetComponent<Rigidbody>().velocity = Vector3.up * flyVelocity; 
        }
    }
}
