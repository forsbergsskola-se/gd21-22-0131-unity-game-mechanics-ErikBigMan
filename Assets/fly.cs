using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fly : MonoBehaviour
{
    private Rigidbody rb;
    
    [Range(1, 10)] public float flyVelocity;
    [Range(1, 100)] public float flyForwardVelocity;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            GetComponent<Rigidbody>().velocity = Vector3.up * flyVelocity;
            rb.AddForce(transform.right * flyForwardVelocity);
        }
        if (Input.GetButton("jump"))
        {
            rb.AddForce(transform.up * flyVelocity);
        }

    }
}
