using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class fly2 : MonoBehaviour
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

    public void movmentscript2()
    {
        if (Input.GetButton("HorizontalRight"))
        {
            rb.AddForce(transform.right * flyForwardVelocity);
            
            //rb.velocity = (Vector3.right * flyVelocity);// + (Vector3.up * flyVelocity);
        }
        if (Input.GetButton("HorizontalLeft"))
        {
            rb.AddForce(-transform.right * flyForwardVelocity);
            //rb.velocity = (Vector3.left * flyForwardVelocity); // + (Vector3.up * flyVelocity) ;
        }
        
        if (Input.GetButton("Jump"))
        {
            rb.velocity = Vector3.up * flyVelocity;
            if (Input.GetButton("HorizontalLeft"))
            {
                rb.velocity = (Vector3.left * flyForwardVelocity) + (Vector3.up * flyVelocity);
            }
            else if (Input.GetButton("HorizontalRight"))
            {
                rb.velocity = (Vector3.right * flyForwardVelocity) + (Vector3.up * flyVelocity);
            }
        }
        
        
    }
    
    
    private void Update()
    {
        movmentscript2();
        
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
