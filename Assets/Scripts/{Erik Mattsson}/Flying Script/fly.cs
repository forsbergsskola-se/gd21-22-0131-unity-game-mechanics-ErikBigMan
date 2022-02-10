using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class fly : MonoBehaviour
{
    
    public float jetpackDuration;
    public float rechargeDuration;
    public float boost;
    public float Grounded = 1f;
    
    
    public Rigidbody rb;
    
    [Range(1, 10)] public float flyVelocity;
    [Range(1, 100)] public float flyForwardVelocity;

    public void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    [SerializeField] private void movmentscript()
    {
        if (Input.GetButtonDown("HorizontalRight"))
        {
            GetComponent<Rigidbody>().velocity = Vector3.up * flyVelocity;
            rb.AddForce(transform.right * flyForwardVelocity);
            boost-=Time.deltaTime/jetpackDuration;
        }
        else if (Input.GetButtonDown("HorizontalLeft"))
        {
            GetComponent<Rigidbody>().velocity = Vector3.up * flyVelocity;
            rb.AddForce(-transform.right * flyForwardVelocity); 
            boost-=Time.deltaTime/jetpackDuration;
        }
        else if (Input.GetButton("Jump"))
        {
            rb.AddForce(transform.up * flyVelocity);
            boost-=Time.deltaTime/jetpackDuration;
        } 
    }
    
    
    private void Update()
    {
        movmentscript();
        
        var isgrounded = Physics.Raycast(transform.position, Vector3.down, Grounded);

        if (isgrounded)
        {
          boost = Mathf.Clamp(boost+Time.deltaTime/rechargeDuration, 0, 1);  
        }

        if (Input.GetButton("Jump") || Input.GetButtonDown("HorizontalLeft") || Input.GetButtonDown("HorizontalRight") && boost > 0)
        {
            //movmentscript = null;
        }
    } 
}
