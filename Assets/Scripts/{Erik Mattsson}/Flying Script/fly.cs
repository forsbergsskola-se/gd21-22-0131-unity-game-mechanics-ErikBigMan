using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class fly : MonoBehaviour
{
    
    //public float jetpackDuration;
    //public float rechargeDuration;
    //public float boost = 1;
    //public float Grounded = 1f;
    
    
    public Rigidbody rb;
    
    [Range(1, 10)] public float flyVelocity;
    [Range(1, 100)] public float flyForwardVelocity;

    public void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    public void movmentscript()
    {
        if (Input.GetButtonDown("HorizontalRight"))
        {
            GetComponent<Rigidbody>().velocity = Vector3.up * flyVelocity;
            rb.AddForce(transform.right * flyForwardVelocity);
            //boost-=Time.deltaTime/jetpackDuration;
        }
        else if (Input.GetButtonDown("HorizontalLeft"))
        {
            GetComponent<Rigidbody>().velocity = Vector3.up * flyVelocity;
            rb.AddForce(-transform.right * flyForwardVelocity); 
            //boost-=Time.deltaTime/jetpackDuration;
        }
        else if (Input.GetButton("Jump"))
        {
            GetComponent<Rigidbody>().velocity = Vector3.up * flyVelocity;
            //boost-=Time.deltaTime/jetpackDuration;
        } 
    }
    
    
    private void Update()
    {
        movmentscript();
        
        /*var isgrounded = Physics.Raycast(transform.position, Vector3.down, Grounded);

        if (Input.GetButton("Jump") && boost < 0|| Input.GetButtonDown("HorizontalLeft") && boost < 0|| Input.GetButtonDown("HorizontalRight") && boost < 0)
        {
            movmentscript(); enabled = false;
        }
        if (isgrounded)
        { 
            boost = Mathf.Clamp(boost+Time.deltaTime/rechargeDuration, 1, 1);
            if (boost > 0)
            {
                movmentscript();
                enabled = true;
            }
        }*/
    }
}
