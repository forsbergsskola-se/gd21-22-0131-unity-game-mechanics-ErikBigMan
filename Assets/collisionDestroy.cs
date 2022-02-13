using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class collisionDestroy : MonoBehaviour
{
    
    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Spike")
        {
            transform.position = new Vector3(-2.07f,1.11f,-3.57f);
        }
    }
}
